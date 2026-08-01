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

namespace LeetCode.Algorithms.LongestNiceSubarray;

/// <summary>
///     https://leetcode.com/problems/longest-nice-subarray/description/
/// </summary>
public interface ILongestNiceSubarray
{
    /// <summary>
    ///     Finds the length of the longest contiguous subarray of <paramref name="nums" /> in which the bitwise AND of every pair of elements equals
    ///     <c>0</c>.
    /// </summary>
    /// <param name="nums">The array of integers to examine.</param>
    /// <returns>The length of the longest nice subarray.</returns>
    int LongestNiceSubarray(int[] nums);
}