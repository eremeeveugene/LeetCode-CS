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

namespace LeetCode.Algorithms.MinimumRemovalsToBalanceArray;

/// <summary>
///     https://leetcode.com/problems/minimum-removals-to-balance-array/description/
/// </summary>
public interface IMinimumRemovalsToBalanceArray
{
    /// <summary>
    ///     Determines the minimum number of elements to remove from <paramref name="nums" /> so that the remaining array is
    ///     balanced, i.e. its maximum element is at most <paramref name="k" /> times its minimum element.
    /// </summary>
    /// <param name="nums">The array of integers to balance.</param>
    /// <param name="k">The maximum allowed ratio between the maximum and minimum elements of the balanced array.</param>
    /// <returns>The minimum number of elements that must be removed so the remaining array is balanced.</returns>
    int MinRemoval(int[] nums, int k);
}