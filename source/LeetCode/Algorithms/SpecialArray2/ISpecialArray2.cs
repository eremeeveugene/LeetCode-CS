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

namespace LeetCode.Algorithms.SpecialArray2;

/// <summary>
///     https://leetcode.com/problems/special-array-ii/description/
/// </summary>
public interface ISpecialArray2
{
    /// <summary>
    ///     For each query range in <paramref name="queries" />, determines whether every pair of adjacent
    ///     elements within that subarray of <paramref name="nums" /> has different parity.
    /// </summary>
    /// <param name="nums">The array of integers to check.</param>
    /// <param name="queries">The array of queries, each specifying a start and end index of a subarray of <paramref name="nums" />.</param>
    /// <returns>An array of booleans indicating, for each query, whether the corresponding subarray is special.</returns>
    bool[] IsArraySpecial(int[] nums, int[][] queries);
}