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

namespace LeetCode.Algorithms.FindMissingAndRepeatedValues;

/// <summary>
///     https://leetcode.com/problems/find-missing-and-repeated-values/description/
/// </summary>
public interface IFindMissingAndRepeatedValues
{
    /// <summary>
    ///     Finds the repeated and the missing values in <paramref name="grid" />, which contains all numbers from 1 to
    ///     n * n except that one value appears twice and one value is absent.
    /// </summary>
    /// <param name="grid">The n x n matrix of integers.</param>
    /// <returns>An array of two elements where the first is the repeated value and the second is the missing value.</returns>
    int[] FindMissingAndRepeatedValues(int[][] grid);
}