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

namespace LeetCode.Algorithms.ArithmeticSubarrays;

/// <summary>
///     https://leetcode.com/problems/arithmetic-subarrays/
/// </summary>
public interface IArithmeticSubarrays
{
    /// <summary>
    ///     Determines for each range query whether the subarray of <paramref name="nums" /> from <paramref name="l" />[i]
    ///     to <paramref name="r" />[i] can be rearranged to form an arithmetic sequence.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <param name="l">The left boundaries of the range queries.</param>
    /// <param name="r">The right boundaries of the range queries.</param>
    /// <returns>A list where each element is <c>true</c> if the corresponding subarray can be rearranged into an arithmetic sequence; otherwise, <c>false</c>.</returns>
    IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r);
}