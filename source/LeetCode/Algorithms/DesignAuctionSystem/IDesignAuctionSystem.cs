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

/// <summary>
///     https://leetcode.com/problems/design-auction-system/description/
/// </summary>
public interface IDesignAuctionSystem
{
    /// <summary>
    ///     Adds a bid or replaces the user's existing bid for the item.
    /// </summary>
    /// <param name="userId">The user identifier.</param>
    /// <param name="itemId">The item identifier.</param>
    /// <param name="bidAmount">The bid amount.</param>
    void AddBid(int userId, int itemId, int bidAmount);

    /// <summary>
    ///     Updates an existing bid for the item.
    /// </summary>
    /// <param name="userId">The user identifier.</param>
    /// <param name="itemId">The item identifier.</param>
    /// <param name="newAmount">The replacement bid amount.</param>
    void UpdateBid(int userId, int itemId, int newAmount);

    /// <summary>
    ///     Removes the user's existing bid for the item.
    /// </summary>
    /// <param name="userId">The user identifier.</param>
    /// <param name="itemId">The item identifier.</param>
    void RemoveBid(int userId, int itemId);

    /// <summary>
    ///     Returns the highest bidder, breaking ties by the highest user identifier.
    /// </summary>
    /// <param name="itemId">The item identifier.</param>
    /// <returns>The highest bidder's identifier, or -1 if the item has no bids.</returns>
    int GetHighestBidder(int itemId);
}