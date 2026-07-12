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

namespace LeetCode.Algorithms.ConcatenationOfArray;

/// <summary>
///     https://leetcode.com/problems/concatenation-of-array/
/// </summary>
public interface IConcatenationOfArray
{
    /// <summary>
    ///     Builds an array of twice the length of <paramref name="nums" /> formed by concatenating <paramref name="nums" />
    ///     with itself.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <returns>The concatenation of <paramref name="nums" /> with itself.</returns>
    int[] GetConcatenation(int[] nums);
}