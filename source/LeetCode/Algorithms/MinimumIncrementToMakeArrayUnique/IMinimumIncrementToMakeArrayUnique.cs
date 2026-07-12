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

namespace LeetCode.Algorithms.MinimumIncrementToMakeArrayUnique;

/// <summary>
///     https://leetcode.com/problems/minimum-increment-to-make-array-unique/description/
/// </summary>
public interface IMinimumIncrementToMakeArrayUnique
{
    /// <summary>
    ///     Increments elements of <paramref name="nums" /> by 1 any number of times so that all elements become
    ///     unique, and finds the minimum total number of increments required.
    /// </summary>
    /// <param name="nums">The array of integers to make unique.</param>
    /// <returns>The minimum total number of increment operations required.</returns>
    int MinIncrementForUnique(int[] nums);
}