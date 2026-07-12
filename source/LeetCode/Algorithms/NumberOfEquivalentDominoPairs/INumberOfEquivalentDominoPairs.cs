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

namespace LeetCode.Algorithms.NumberOfEquivalentDominoPairs;

/// <summary>
///     https://leetcode.com/problems/number-of-equivalent-domino-pairs/description/
/// </summary>
public interface INumberOfEquivalentDominoPairs
{
    /// <summary>
    ///     Counts the number of pairs of equivalent dominoes in <paramref name="dominoes" />, where two dominoes are
    ///     equivalent if their values are equal or are reverses of each other.
    /// </summary>
    /// <param name="dominoes">The list of dominoes, each represented as a two-element array [a, b].</param>
    /// <returns>The number of equivalent domino pairs found in <paramref name="dominoes" />.</returns>
    int NumEquivDominoPairs(int[][] dominoes);
}