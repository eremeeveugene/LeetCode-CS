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

namespace LeetCode.Algorithms.ConcatenateNonZeroDigitsAndMultiplyBySum2;

/// <summary>
///     https://leetcode.com/problems/concatenate-non-zero-digits-and-multiply-by-sum-ii/description/
/// </summary>
public interface IConcatenateNonZeroDigitsAndMultiplyBySum2
{
    /// <summary>
    ///     For each query [l, r], forms an integer x by concatenating the non-zero digits of the substring s[l..r] in their
    ///     original order (x = 0 if there are none) and computes x multiplied by the sum of the digits of x.
    /// </summary>
    /// <param name="s">The string of digits.</param>
    /// <param name="queries">The array of queries, where each query is a pair [l, r] of substring bounds.</param>
    /// <returns>An array where the ith element is the answer to the ith query, modulo 10^9 + 7.</returns>
    int[] SumAndMultiply(string s, int[][] queries);
}