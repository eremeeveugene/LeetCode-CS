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

namespace LeetCode.Algorithms.MaximumAlternatingSumOfSquares;

/// <summary>
///     https://leetcode.com/problems/maximum-alternating-sum-of-squares/description/
/// </summary>
public interface IMaximumAlternatingSumOfSquares
{
    /// <summary>
    ///     Calculates the maximum alternating score arr[0]^2 - arr[1]^2 + arr[2]^2 - ... over all rearrangements of the
    ///     given array.
    /// </summary>
    /// <param name="nums">An array of integers that may be rearranged in any order.</param>
    /// <returns>The maximum possible alternating sum of squares.</returns>
    long MaxAlternatingSum(int[] nums);
}