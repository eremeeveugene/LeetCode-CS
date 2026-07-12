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

namespace LeetCode.Algorithms.HandOfStraights;

/// <summary>
///     https://leetcode.com/problems/hand-of-straights/
/// </summary>
public interface IHandOfStraights
{
    /// <summary>
    ///     Determines whether the cards in <paramref name="hand" /> can be rearranged into groups of
    ///     <paramref name="groupSize" /> consecutive cards.
    /// </summary>
    /// <param name="hand">The values of the cards in the hand.</param>
    /// <param name="groupSize">The required size of each group.</param>
    /// <returns><c>true</c> if the cards can be rearranged into groups of consecutive cards; otherwise, <c>false</c>.</returns>
    bool IsNStraightHand(int[] hand, int groupSize);
}