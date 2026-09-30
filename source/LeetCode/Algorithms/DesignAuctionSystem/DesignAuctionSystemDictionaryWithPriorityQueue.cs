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

namespace LeetCode.Algorithms.DesignAuctionSystem;

/// <inheritdoc />
/// <remarks>
///     Tracks current bid amounts and lazily removes outdated bids from each item's priority queue.
///     A descending priority comparer puts the highest bid amount and highest user identifier first.
///     Space complexity - O(n), where n is the number of added and updated bids
/// </remarks>
public sealed class DesignAuctionSystemDictionaryWithPriorityQueue : IDesignAuctionSystem
{
    private static readonly Comparer<(int BidAmount, int UserId)> BidPriorityComparer =
        Comparer<(int BidAmount, int UserId)>.Create(static (left, right) => right.CompareTo(left));

    private readonly Dictionary<int, PriorityQueue<(int UserId, int BidAmount), (int BidAmount, int UserId)>> _itemIdToBidsDictionary = [];
    private readonly Dictionary<(int UserId, int ItemId), int> _userAndItemToBidAmountDictionary = [];

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log(h + 1)) amortized, where h is the number of queued bids for the item
    ///     Space complexity - O(1) amortized
    /// </remarks>
    public void AddBid(int userId, int itemId, int bidAmount)
    {
        _userAndItemToBidAmountDictionary[(userId, itemId)] = bidAmount;

        if (!_itemIdToBidsDictionary.TryGetValue(itemId, out var bids))
        {
            bids = new PriorityQueue<(int UserId, int BidAmount), (int BidAmount, int UserId)>(BidPriorityComparer);

            _itemIdToBidsDictionary.Add(itemId, bids);
        }

        bids.Enqueue((userId, bidAmount), (bidAmount, userId));
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log(h + 1)) amortized, where h is the number of queued bids for the item
    ///     Space complexity - O(1) amortized
    /// </remarks>
    public void UpdateBid(int userId, int itemId, int newAmount)
    {
        _userAndItemToBidAmountDictionary[(userId, itemId)] = newAmount;

        var bids = _itemIdToBidsDictionary[itemId];

        bids.Enqueue((userId, newAmount), (newAmount, userId));
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Leaves queued entries to be discarded when they reach the front of the queue.
    ///     Time complexity - O(1) expected
    ///     Space complexity - O(1)
    /// </remarks>
    public void RemoveBid(int userId, int itemId)
    {
        _userAndItemToBidAmountDictionary.Remove((userId, itemId));
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Each outdated queue entry is removed at most once.
    ///     Time complexity - O(1 + e log(h + 1)), where e is the number of discarded entries and h is the queue size
    ///     Space complexity - O(1)
    /// </remarks>
    public int GetHighestBidder(int itemId)
    {
        if (!_itemIdToBidsDictionary.TryGetValue(itemId, out var bids))
        {
            return -1;
        }

        while (bids.TryPeek(out var bid, out _))
        {
            if (_userAndItemToBidAmountDictionary.TryGetValue((bid.UserId, itemId), out var currentAmount) && currentAmount == bid.BidAmount)
            {
                return bid.UserId;
            }

            bids.Dequeue();
        }

        return -1;
    }
}