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

namespace LeetCode.Algorithms.TopKFrequentElements;

/// <summary>
///     https://leetcode.com/problems/top-k-frequent-elements/description/
/// </summary>
public interface ITopKFrequentElements
{
    /// <summary>
    ///     Finds the <paramref name="k" /> most frequently occurring elements in the integer array.
    /// </summary>
    /// <param name="nums">The integer array to analyze.</param>
    /// <param name="k">The number of most frequent distinct elements to return.</param>
    /// <returns>An array containing the <paramref name="k" /> most frequent elements, in any order.</returns>
    int[] TopKFrequent(int[] nums, int k);
}