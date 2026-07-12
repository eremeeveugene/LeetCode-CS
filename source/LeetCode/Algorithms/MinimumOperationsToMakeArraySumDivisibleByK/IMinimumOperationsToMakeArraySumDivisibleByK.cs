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

namespace LeetCode.Algorithms.MinimumOperationsToMakeArraySumDivisibleByK;

/// <summary>
///     https://leetcode.com/problems/minimum-operations-to-make-array-sum-divisible-by-k/description/
/// </summary>
public interface IMinimumOperationsToMakeArraySumDivisibleByK
{
    /// <summary>
    ///     Finds the minimum number of operations needed to make the sum of <paramref name="nums" /> divisible by
    ///     <paramref name="k" />, where each operation decrements a single element by one.
    /// </summary>
    /// <param name="nums">The array of integers whose sum should become divisible by <paramref name="k" />.</param>
    /// <param name="k">The divisor that the sum of <paramref name="nums" /> must be evenly divisible by.</param>
    /// <returns>The minimum number of decrement operations required.</returns>
    int MinOperations(int[] nums, int k);
}