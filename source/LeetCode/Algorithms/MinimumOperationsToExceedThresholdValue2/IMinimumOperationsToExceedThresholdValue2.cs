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

namespace LeetCode.Algorithms.MinimumOperationsToExceedThresholdValue2;

/// <summary>
///     https://leetcode.com/problems/minimum-operations-to-exceed-threshold-value-ii/description/
/// </summary>
public interface IMinimumOperationsToExceedThresholdValue2
{
    /// <summary>
    ///     Finds the minimum number of operations needed so that every element of <paramref name="nums" /> becomes
    ///     greater than or equal to <paramref name="k" />, where each operation removes the two smallest elements and
    ///     inserts their combined value <c>2 * min + max</c> back into the array.
    /// </summary>
    /// <param name="nums">The array of integers to operate on.</param>
    /// <param name="k">The threshold value that every element must reach or exceed.</param>
    /// <returns>The minimum number of operations required.</returns>
    int MinOperations(int[] nums, int k);
}