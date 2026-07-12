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

namespace LeetCode.Algorithms.LongestHarmoniousSubsequence;

/// <summary>
///     https://leetcode.com/problems/longest-harmonious-subsequence/
/// </summary>
public interface ILongestHarmoniousSubsequence
{
    /// <summary>
    ///     Finds the length of the longest subsequence of <paramref name="nums" /> in which the maximum and minimum values differ by exactly <c>1</c>.
    /// </summary>
    /// <param name="nums">The array of integers to examine.</param>
    /// <returns>The length of the longest harmonious subsequence, or <c>0</c> if none exists.</returns>
    int FindLHS(int[] nums);
}