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

namespace LeetCode.Algorithms.FindSubsequenceOfLengthKWithTheLargestSum;

/// <summary>
///     https://leetcode.com/problems/find-subsequence-of-length-k-with-the-largest-sum/description/
/// </summary>
public interface IFindSubsequenceOfLengthKWithTheLargestSum
{
    /// <summary>
    ///     Finds a subsequence of <paramref name="nums" /> of length <paramref name="k" /> that has the largest sum, preserving the original order of
    ///     elements.
    /// </summary>
    /// <param name="nums">The array of integers to select a subsequence from.</param>
    /// <param name="k">The length of the subsequence to find.</param>
    /// <returns>The subsequence of length <paramref name="k" /> with the largest sum, in original order.</returns>
    int[] MaxSubsequence(int[] nums, int k);
}