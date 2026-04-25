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

namespace LeetCode.Algorithms.SumOfDistances;

/// <summary>
///     https://leetcode.com/problems/sum-of-distances/description/
/// </summary>
public interface ISumOfDistances
{
    /// <summary>
    ///     Calculates the sum of distances from each index to all other indices with the same value.
    /// </summary>
    /// <param name="nums">A 0-indexed integer array.</param>
    /// <returns>An array where each value is the sum of absolute distances to equal values.</returns>
    long[] Distance(int[] nums);
}