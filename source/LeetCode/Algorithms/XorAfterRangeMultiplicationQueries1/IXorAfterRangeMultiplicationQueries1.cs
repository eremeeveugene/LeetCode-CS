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

namespace LeetCode.Algorithms.XorAfterRangeMultiplicationQueries1;

/// <summary>
///     https://leetcode.com/problems/xor-after-range-multiplication-queries-i/description/
/// </summary>
public interface IXorAfterRangeMultiplicationQueries1
{
    /// <summary>
    ///     Applies each query by multiplying every step-th element within the range by the given value modulo 10^9 + 7 and
    ///     returns the bitwise XOR of all elements.
    /// </summary>
    /// <param name="nums">The array of integers to process.</param>
    /// <param name="queries">The queries, where each query is [left, right, step, value].</param>
    /// <returns>The bitwise XOR of all elements after processing all queries.</returns>
    int XorAfterQueries(int[] nums, int[][] queries);
}