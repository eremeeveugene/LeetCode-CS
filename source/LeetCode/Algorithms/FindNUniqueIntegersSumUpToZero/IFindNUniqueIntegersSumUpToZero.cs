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

namespace LeetCode.Algorithms.FindNUniqueIntegersSumUpToZero;

/// <summary>
///     https://leetcode.com/problems/find-n-unique-integers-sum-up-to-zero/description/
/// </summary>
public interface IFindNUniqueIntegersSumUpToZero
{
    /// <summary>
    ///     Finds <paramref name="n" /> unique integers that sum up to zero.
    /// </summary>
    /// <param name="n">The number of unique integers to produce.</param>
    /// <returns>An array of <paramref name="n" /> unique integers whose sum is zero.</returns>
    int[] SumZero(int n);
}