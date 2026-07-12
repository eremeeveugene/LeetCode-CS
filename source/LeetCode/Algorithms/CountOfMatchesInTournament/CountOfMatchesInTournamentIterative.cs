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

/// <inheritdoc />
public sealed class CountOfMatchesInTournamentIterative : ICountOfMatchesInTournament
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int NumberOfMatches(int n)
    {
        var numberOfMatches = 0;

        while (n > 1)
        {
            var roundMatches = n / 2;

            numberOfMatches += roundMatches;

            n -= roundMatches;
        }

        return numberOfMatches;
    }
}