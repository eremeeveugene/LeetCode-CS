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

namespace LeetCode.Algorithms.CountElementsWithMaximumFrequency;

/// <summary>
///     https://leetcode.com/problems/count-elements-with-maximum-frequency/
/// </summary>
public interface ICountElementsWithMaximumFrequency
{
    /// <summary>
    ///     Counts the total number of elements in <paramref name="nums" /> whose frequency equals the maximum frequency of
    ///     any element in the array.
    /// </summary>
    /// <param name="nums">The array of positive integers.</param>
    /// <returns>The total count of elements that have the maximum frequency.</returns>
    int MaxFrequencyElements(int[] nums);
}