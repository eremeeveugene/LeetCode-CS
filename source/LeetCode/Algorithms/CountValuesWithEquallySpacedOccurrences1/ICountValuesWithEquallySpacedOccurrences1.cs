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

namespace LeetCode.Algorithms.CountValuesWithEquallySpacedOccurrences1;

/// <summary>
///     https://leetcode.com/problems/count-values-with-equally-spaced-occurrences-i/description/
/// </summary>
public interface ICountValuesWithEquallySpacedOccurrences1
{
    /// <summary>
    ///     Counts distinct values that occur exactly three times at equally spaced indices.
    /// </summary>
    /// <param name="nums">The array of integers to examine.</param>
    /// <returns>The number of distinct values with exactly three equally spaced occurrences.</returns>
    int CountSpecialIntegers(int[] nums);
}