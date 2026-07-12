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

namespace LeetCode.Algorithms.ContiguousArray;

/// <summary>
///     https://leetcode.com/problems/contiguous-array/
/// </summary>
public interface IContiguousArray
{
    /// <summary>
    ///     Finds the maximum length of a contiguous subarray of <paramref name="nums" /> containing an equal number of
    ///     0s and 1s.
    /// </summary>
    /// <param name="nums">The binary array of 0s and 1s.</param>
    /// <returns>The length of the longest contiguous subarray with an equal number of 0s and 1s.</returns>
    int FindMaxLength(int[] nums);
}