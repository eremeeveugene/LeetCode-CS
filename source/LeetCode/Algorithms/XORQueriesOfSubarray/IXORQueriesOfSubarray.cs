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

namespace LeetCode.Algorithms.XORQueriesOfSubarray;

/// <summary>
///     https://leetcode.com/problems/xor-queries-of-a-subarray/description/
/// </summary>
public interface IXORQueriesOfSubarray
{
    /// <summary>
    ///     Computes, for each range in <paramref name="queries" />, the bitwise XOR of all elements of
    ///     <paramref name="arr" /> within that inclusive range.
    /// </summary>
    /// <param name="arr">The array of integers to query.</param>
    /// <param name="queries">The array of ranges, each given as an inclusive start and end index.</param>
    /// <returns>An array where each element is the XOR result for the corresponding query.</returns>
    int[] XorQueries(int[] arr, int[][] queries);
}