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

namespace LeetCode.Algorithms.IntervalsBetweenIdenticalElements;

/// <summary>
///     https://leetcode.com/problems/intervals-between-identical-elements/description/
/// </summary>
public interface IIntervalsBetweenIdenticalElements
{
    /// <summary>
    ///     Calculates the sum of intervals between each index and all other indices with the same value.
    /// </summary>
    /// <param name="nums">A 0-indexed integer array.</param>
    /// <returns>An array where each value is the sum of absolute index distances to equal values.</returns>
    long[] GetDistances(int[] nums);
}