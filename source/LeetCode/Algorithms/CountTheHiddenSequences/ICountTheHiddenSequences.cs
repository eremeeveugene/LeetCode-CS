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

namespace LeetCode.Algorithms.CountTheHiddenSequences;

/// <summary>
///     https://leetcode.com/problems/count-the-hidden-sequences/description/
/// </summary>
public interface ICountTheHiddenSequences
{
    /// <summary>
    ///     Counts the number of hidden integer arrays whose consecutive differences match <paramref name="differences" />
    ///     and whose every element lies within the inclusive range [<paramref name="lower" />, <paramref name="upper" />].
    /// </summary>
    /// <param name="differences">The array of consecutive differences of the hidden sequence.</param>
    /// <param name="lower">The inclusive lower bound for every element of the hidden sequence.</param>
    /// <param name="upper">The inclusive upper bound for every element of the hidden sequence.</param>
    /// <returns>The number of possible hidden sequences satisfying the given constraints.</returns>
    int NumberOfArrays(int[] differences, int lower, int upper);
}