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

namespace LeetCode.Algorithms.ShortestSubarrayWithSumAtLeastK;

/// <summary>
///     https://leetcode.com/problems/shortest-subarray-with-sum-at-least-k/description/
/// </summary>
public interface IShortestSubarrayWithSumAtLeastK
{
    /// <summary>
    ///     Finds the length of the shortest, possibly negative, contiguous subarray of <paramref name="nums" />
    ///     whose sum is at least <paramref name="k" />.
    /// </summary>
    /// <param name="nums">The array of integers to search.</param>
    /// <param name="k">The minimum required sum.</param>
    /// <returns>The length of the shortest qualifying subarray, or -1 if none exists.</returns>
    int ShortestSubarray(int[] nums, int k);
}