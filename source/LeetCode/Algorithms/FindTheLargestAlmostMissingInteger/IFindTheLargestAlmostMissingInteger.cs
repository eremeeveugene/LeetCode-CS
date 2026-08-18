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

namespace LeetCode.Algorithms.FindTheLargestAlmostMissingInteger;

/// <summary>
///     https://leetcode.com/problems/find-the-largest-almost-missing-integer/description/
/// </summary>
public interface IFindTheLargestAlmostMissingInteger
{
    /// <summary>
    ///     Finds the largest integer that appears in exactly one subarray of size <paramref name="k" />.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <param name="k">The size of each subarray.</param>
    /// <returns>The largest almost missing integer, or -1 if no such integer exists.</returns>
    int LargestInteger(int[] nums, int k);
}