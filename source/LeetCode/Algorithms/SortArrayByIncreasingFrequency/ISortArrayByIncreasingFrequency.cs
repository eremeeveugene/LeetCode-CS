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

namespace LeetCode.Algorithms.SortArrayByIncreasingFrequency;

/// <summary>
///     https://leetcode.com/problems/sort-array-by-increasing-frequency/
/// </summary>
public interface ISortArrayByIncreasingFrequency
{
    /// <summary>
    ///     Sorts <paramref name="nums" /> in increasing order of frequency; if multiple values have the same
    ///     frequency, sorts those values in decreasing order.
    /// </summary>
    /// <param name="nums">The array of integers to sort.</param>
    /// <returns>A new array containing the elements of <paramref name="nums" /> sorted by frequency.</returns>
    int[] FrequencySort(int[] nums);
}