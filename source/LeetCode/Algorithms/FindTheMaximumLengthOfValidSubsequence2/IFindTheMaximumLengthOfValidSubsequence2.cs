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

namespace LeetCode.Algorithms.FindTheMaximumLengthOfValidSubsequence2;

/// <summary>
///     https://leetcode.com/problems/find-the-maximum-length-of-valid-subsequence-ii/description/
/// </summary>
public interface IFindTheMaximumLengthOfValidSubsequence2
{
    /// <summary>
    ///     Finds the length of the longest valid subsequence of <paramref name="nums" />, where a subsequence is valid if
    ///     the sum of every pair of consecutive elements has the same remainder modulo <paramref name="k" />.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <param name="k">The modulus applied to the sums of consecutive subsequence elements.</param>
    /// <returns>The length of the longest valid subsequence.</returns>
    int MaximumLength(int[] nums, int k);
}