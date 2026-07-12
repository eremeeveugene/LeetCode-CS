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

namespace LeetCode.Algorithms.FindMissingObservations;

/// <summary>
///     https://leetcode.com/problems/find-missing-observations/
/// </summary>
public interface IFindMissingObservations
{
    /// <summary>
    ///     Finds <paramref name="n" /> missing dice observations such that the mean of all observations, including
    ///     <paramref name="rolls" />, equals <paramref name="mean" />.
    /// </summary>
    /// <param name="rolls">The observed dice rolls.</param>
    /// <param name="mean">The required mean of all observations.</param>
    /// <param name="n">The number of missing observations.</param>
    /// <returns>An array of <paramref name="n" /> valid dice values, or an empty array if no answer exists.</returns>
    int[] MissingRolls(int[] rolls, int mean, int n);
}