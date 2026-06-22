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

/// <summary>
///     https://leetcode.com/problems/design-twitter/description
/// </summary>
public interface IDesignTwitter
{
    /// <summary>
    ///     Composes a new tweet with id <paramref name="tweetId" /> authored by user <paramref name="userId" />. Every call is
    ///     made with a unique <paramref name="tweetId" />.
    /// </summary>
    /// <param name="userId">The id of the user composing the tweet.</param>
    /// <param name="tweetId">The unique id of the tweet being composed.</param>
    void PostTweet(int userId, int tweetId);

    /// <summary>
    ///     Retrieves the ids of the <c>10</c> most recent tweets in the news feed of user <paramref name="userId" />, where
    ///     each tweet is authored either by the user themselves or by someone they follow, ordered from most recent to least
    ///     recent.
    /// </summary>
    /// <param name="userId">The id of the user whose news feed is requested.</param>
    /// <returns>The ids of up to <c>10</c> most recent relevant tweets, ordered from most recent to least recent.</returns>
    IList<int> GetNewsFeed(int userId);

    /// <summary>
    ///     Makes user <paramref name="followerId" /> start following user <paramref name="followeeId" />. The call has no
    ///     effect if the follow relationship already exists.
    /// </summary>
    /// <param name="followerId">The id of the user that starts following.</param>
    /// <param name="followeeId">The id of the user being followed.</param>
    void Follow(int followerId, int followeeId);

    /// <summary>
    ///     Makes user <paramref name="followerId" /> stop following user <paramref name="followeeId" />. The call has no effect
    ///     if the follow relationship does not exist.
    /// </summary>
    /// <param name="followerId">The id of the user that stops following.</param>
    /// <param name="followeeId">The id of the user being unfollowed.</param>
    void Unfollow(int followerId, int followeeId);
}