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

namespace LeetCode.Algorithms.CountOfMatchesInTournament;

/// <summary>
///     https://leetcode.com/problems/count-of-matches-in-tournament/
/// </summary>
public interface ICountOfMatchesInTournament
{
    /// <summary>
    ///     Computes the total number of matches played in a single-elimination tournament starting with
    ///     <paramref name="n" /> teams.
    /// </summary>
    /// <param name="n">The number of teams entering the tournament.</param>
    /// <returns>The total number of matches played until a winner is determined.</returns>
    int NumberOfMatches(int n);
}