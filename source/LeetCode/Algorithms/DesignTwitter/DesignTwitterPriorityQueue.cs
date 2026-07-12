// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.DesignTwitter;

/// <inheritdoc />
public sealed class DesignTwitterPriorityQueue : IDesignTwitter
{
    private const int NewsFeedSize = 10;
    private readonly Dictionary<int, HashSet<int>> _userToFolloweesDictionary = new();
    private readonly Dictionary<int, List<(int Timestamp, int TweetId)>> _userToTweetsDictionary = new();
    private int _timestamp;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void PostTweet(int userId, int tweetId)
    {
        if (!_userToTweetsDictionary.TryGetValue(userId, out var tweets))
        {
            tweets = [];

            _userToTweetsDictionary[userId] = tweets;
        }

        tweets.Add((_timestamp++, tweetId));
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(t * log(k)) where t is the number of recent tweets examined across the user and their
    ///     followees and k is the news feed size of 10
    ///     Space complexity - O(k)
    /// </remarks>
    public IList<int> GetNewsFeed(int userId)
    {
        var oldestFirst = new PriorityQueue<int, int>();

        CollectRecentTweets(oldestFirst, userId);

        if (_userToFolloweesDictionary.TryGetValue(userId, out var followees))
        {
            foreach (var followeeId in followees)
            {
                if (followeeId == userId)
                {
                    continue;
                }

                CollectRecentTweets(oldestFirst, followeeId);
            }
        }

        var newsFeed = new int[oldestFirst.Count];

        for (var i = newsFeed.Length - 1; i >= 0; i--)
        {
            newsFeed[i] = oldestFirst.Dequeue();
        }

        return newsFeed;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Follow(int followerId, int followeeId)
    {
        if (!_userToFolloweesDictionary.TryGetValue(followerId, out var followees))
        {
            followees = [];

            _userToFolloweesDictionary[followerId] = followees;
        }

        followees.Add(followeeId);
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Unfollow(int followerId, int followeeId)
    {
        if (_userToFolloweesDictionary.TryGetValue(followerId, out var followees))
        {
            followees.Remove(followeeId);
        }
    }

    /// <summary>
    ///     Enqueues the most recent tweets (at most <see cref="NewsFeedSize" />) authored by <paramref name="userId" /> into
    ///     <paramref name="oldestFirst" />, evicting the oldest tweet whenever the heap grows beyond <see cref="NewsFeedSize" />
    ///     so it always retains the most recent candidates for the news feed.
    ///     Time complexity - O(k * log(k)) where k is the news feed size of 10
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="oldestFirst">The min-heap, keyed by timestamp, that accumulates news feed candidates.</param>
    /// <param name="userId">The id of the user whose recent tweets are collected.</param>
    private void CollectRecentTweets(PriorityQueue<int, int> oldestFirst, int userId)
    {
        if (!_userToTweetsDictionary.TryGetValue(userId, out var tweets))
        {
            return;
        }

        var oldestIndex = Math.Max(0, tweets.Count - NewsFeedSize);

        for (var i = tweets.Count - 1; i >= oldestIndex; i--)
        {
            var (timestamp, tweetId) = tweets[i];

            oldestFirst.Enqueue(tweetId, timestamp);

            if (oldestFirst.Count > NewsFeedSize)
            {
                oldestFirst.Dequeue();
            }
        }
    }
}