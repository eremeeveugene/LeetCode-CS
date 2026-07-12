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

namespace LeetCode.Algorithms.MaximumNumberOfDistinctElementsAfterOperations;

/// <summary>
///     https://leetcode.com/problems/maximum-number-of-distinct-elements-after-operations/description/
/// </summary>
public interface IMaximumNumberOfDistinctElementsAfterOperations
{
    /// <summary>
    ///     Adjusts each element of <paramref name="nums" /> by an integer in the range
    ///     [-<paramref name="k" />, <paramref name="k" />] (at most once per element) to maximize the number of distinct
    ///     values in the resulting array.
    /// </summary>
    /// <param name="nums">The array of integers to adjust.</param>
    /// <param name="k">The maximum absolute amount by which each element may be adjusted.</param>
    /// <returns>The maximum possible number of distinct elements achievable after the adjustments.</returns>
    int MaxDistinctElements(int[] nums, int k);
}