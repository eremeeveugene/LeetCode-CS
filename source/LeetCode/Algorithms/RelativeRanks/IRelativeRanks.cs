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

namespace LeetCode.Algorithms.RelativeRanks;

/// <summary>
///     https://leetcode.com/problems/relative-ranks/description/
/// </summary>
public interface IRelativeRanks
{
    /// <summary>
    ///     Assigns each athlete's rank based on <paramref name="score" />, using "Gold Medal", "Silver Medal", and
    ///     "Bronze Medal" for the top three scores and the numeric placement for the rest.
    /// </summary>
    /// <param name="score">The array of unique scores, one per athlete.</param>
    /// <returns>An array of rank strings corresponding to each athlete in <paramref name="score" />.</returns>
    string[] FindRelativeRanks(int[] score);
}