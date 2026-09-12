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

namespace LeetCode.Algorithms.LongestContinuousIncreasingSubsequence;

/// <summary>
///     https://leetcode.com/problems/longest-continuous-increasing-subsequence/description/
/// </summary>
public interface ILongestContinuousIncreasingSubsequence
{
    /// <summary>
    ///     Finds the length of the longest contiguous strictly increasing subarray.
    /// </summary>
    /// <param name="nums">A nonempty array of integers.</param>
    /// <returns>The length of the longest continuous increasing subsequence.</returns>
    int FindLengthOfLCIS(int[] nums);
}