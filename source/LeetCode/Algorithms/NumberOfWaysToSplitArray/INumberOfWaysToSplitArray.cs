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

namespace LeetCode.Algorithms.NumberOfWaysToSplitArray;

/// <summary>
///     https://leetcode.com/problems/number-of-ways-to-split-array/description/
/// </summary>
public interface INumberOfWaysToSplitArray
{
    /// <summary>
    ///     Counts the number of ways to split <paramref name="nums" /> into two non-empty contiguous parts such that
    ///     the sum of the left part is greater than or equal to the sum of the right part.
    /// </summary>
    /// <param name="nums">The array of integers to split.</param>
    /// <returns>The number of valid ways to split <paramref name="nums" /> into two parts.</returns>
    int WaysToSplitArray(int[] nums);
}