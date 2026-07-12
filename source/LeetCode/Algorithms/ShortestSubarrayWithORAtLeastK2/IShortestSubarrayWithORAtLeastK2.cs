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

namespace LeetCode.Algorithms.ShortestSubarrayWithORAtLeastK2;

/// <summary>
///     https://leetcode.com/problems/shortest-subarray-with-or-at-least-k-ii/description/
/// </summary>
public interface IShortestSubarrayWithORAtLeastK2
{
    /// <summary>
    ///     Finds the length of the shortest contiguous subarray of <paramref name="nums" /> whose bitwise OR of
    ///     all its elements is at least <paramref name="k" />.
    /// </summary>
    /// <param name="nums">The array of non-negative integers to search.</param>
    /// <param name="k">The minimum required bitwise OR value.</param>
    /// <returns>The length of the shortest qualifying subarray, or -1 if none exists.</returns>
    int MinimumSubarrayLength(int[] nums, int k);
}