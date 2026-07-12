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

namespace LeetCode.Algorithms.RunningSumOf1dArray;

/// <summary>
///     https://leetcode.com/problems/running-sum-of-1d-array/description/
/// </summary>
public interface IRunningSumOf1dArray
{
    /// <summary>
    ///     Computes the running sum of <paramref name="nums" />, where each element is the sum of itself
    ///     and all preceding elements.
    /// </summary>
    /// <param name="nums">The array of integers to accumulate.</param>
    /// <returns>An array containing the running sum of <paramref name="nums" />.</returns>
    int[] RunningSum(int[] nums);
}