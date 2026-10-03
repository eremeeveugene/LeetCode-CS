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

namespace LeetCode.Algorithms.MaximumFrequencyOfAnElementAfterPerformingOperations2;

/// <summary>
///     https://leetcode.com/problems/maximum-frequency-of-an-element-after-performing-operations-ii/description/
/// </summary>
public interface IMaximumFrequencyOfAnElementAfterPerformingOperations2
{
    /// <summary>
    ///     Finds the maximum frequency after changing distinct elements by an amount between -k and k.
    /// </summary>
    /// <param name="nums">The array of positive integers.</param>
    /// <param name="k">The maximum absolute change to a selected element.</param>
    /// <param name="numOperations">The number of operations, each selecting a different index.</param>
    /// <returns>The maximum achievable frequency of any value.</returns>
    int MaxFrequency(int[] nums, int k, int numOperations);
}