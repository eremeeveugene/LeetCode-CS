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

namespace LeetCode.Algorithms.MinimumCapacityBox;

/// <summary>
///     https://leetcode.com/problems/minimum-capacity-box/description/
/// </summary>
public interface IMinimumCapacityBox
{
    /// <summary>
    ///     Finds the index of the box in <paramref name="capacities" /> with the smallest capacity that is still
    ///     large enough to hold an item of size <paramref name="itemSize" />.
    /// </summary>
    /// <param name="capacities">The array of box capacities.</param>
    /// <param name="itemSize">The size of the item that must fit in the chosen box.</param>
    /// <returns>The index of the smallest-capacity box that can hold the item, or -1 if none can.</returns>
    int MinimumIndex(int[] capacities, int itemSize);
}