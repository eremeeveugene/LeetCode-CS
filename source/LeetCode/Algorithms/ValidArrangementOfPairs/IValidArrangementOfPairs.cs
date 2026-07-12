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

namespace LeetCode.Algorithms.ValidArrangementOfPairs;

/// <summary>
///     https://leetcode.com/problems/valid-arrangement-of-pairs/description/
/// </summary>
public interface IValidArrangementOfPairs
{
    /// <summary>
    ///     Reorders <paramref name="pairs" /> so that the second element of each pair equals the first element of
    ///     the next pair, forming a valid Eulerian path.
    /// </summary>
    /// <param name="pairs">The array of pairs, each given as a start value and an end value, to arrange.</param>
    /// <returns>The pairs reordered so that consecutive pairs connect end to start.</returns>
    int[][] ValidArrangement(int[][] pairs);
}