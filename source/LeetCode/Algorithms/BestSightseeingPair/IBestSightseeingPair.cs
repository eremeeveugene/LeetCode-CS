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

namespace LeetCode.Algorithms.BestSightseeingPair;

/// <summary>
///     https://leetcode.com/problems/best-sightseeing-pair/description/
/// </summary>
public interface IBestSightseeingPair
{
    /// <summary>
    ///     Finds the maximum score of a pair of sightseeing spots, where the score of a pair (i, j) is
    ///     values[i] + values[j] + i - j.
    /// </summary>
    /// <param name="values">The values of the sightseeing spots.</param>
    /// <returns>The maximum score of a pair of sightseeing spots.</returns>
    int MaxScoreSightseeingPair(int[] values);
}