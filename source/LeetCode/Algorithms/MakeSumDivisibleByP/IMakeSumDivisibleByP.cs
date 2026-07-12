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

namespace LeetCode.Algorithms.MakeSumDivisibleByP;

/// <summary>
///     https://leetcode.com/problems/make-sum-divisible-by-p/
/// </summary>
public interface IMakeSumDivisibleByP
{
    /// <summary>
    ///     Finds the length of the smallest subarray of <paramref name="nums" /> that must be removed so that the sum of
    ///     the remaining elements is divisible by <paramref name="p" />.
    /// </summary>
    /// <param name="nums">The array of non-negative integers to remove a subarray from.</param>
    /// <param name="p">The divisor that the remaining sum must be divisible by.</param>
    /// <returns>The length of the smallest subarray to remove, or -1 if it is impossible or the whole array would need removing.</returns>
    int MinSubarray(int[] nums, int p);
}