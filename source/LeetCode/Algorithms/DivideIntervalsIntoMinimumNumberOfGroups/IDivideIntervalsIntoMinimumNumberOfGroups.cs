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

namespace LeetCode.Algorithms.DivideIntervalsIntoMinimumNumberOfGroups;

/// <summary>
///     https://leetcode.com/problems/divide-intervals-into-minimum-number-of-groups/
/// </summary>
public interface IDivideIntervalsIntoMinimumNumberOfGroups
{
    /// <summary>
    ///     Computes the minimum number of groups needed to divide <paramref name="intervals" /> such that no two
    ///     intervals in the same group overlap.
    /// </summary>
    /// <param name="intervals">The array of [start, end] inclusive intervals to divide into groups.</param>
    /// <returns>The minimum number of groups required.</returns>
    int MinGroups(int[][] intervals);
}