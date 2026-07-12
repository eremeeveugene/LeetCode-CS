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

namespace LeetCode.Algorithms.FinalArrayStateAfterKMultiplicationOperations;

/// <summary>
///     https://leetcode.com/problems/final-array-state-after-k-multiplication-operations-i/description/
/// </summary>
public interface IFinalArrayStateAfterKMultiplicationOperations
{
    /// <summary>
    ///     Returns the final state of <paramref name="nums" /> after performing <paramref name="k" /> operations, each
    ///     multiplying the first occurrence of the minimum value by <paramref name="multiplier" />.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <param name="k">The number of multiplication operations to perform.</param>
    /// <param name="multiplier">The multiplier applied to the minimum value in each operation.</param>
    /// <returns>The final state of the array after all operations.</returns>
    int[] GetFinalState(int[] nums, int k, int multiplier);
}