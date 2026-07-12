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

namespace LeetCode.Algorithms.RevealCardsInIncreasingOrder;

/// <summary>
///     https://leetcode.com/problems/reveal-cards-in-increasing-order/description/
/// </summary>
public interface IRevealCardsInIncreasingOrder
{
    /// <summary>
    ///     Orders the cards in <paramref name="deck" /> so that revealing them using the reveal-then-move-to-bottom
    ///     process yields the cards in increasing order.
    /// </summary>
    /// <param name="deck">The array of unique card values to reorder.</param>
    /// <returns>The deck ordering that reveals cards in increasing order.</returns>
    int[] DeckRevealedIncreasing(int[] deck);
}