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

namespace LeetCode.Algorithms.MaximumMatchingOfPlayersWithTrainers;

/// <summary>
///     https://leetcode.com/problems/maximum-matching-of-players-with-trainers/description/
/// </summary>
public interface IMaximumMatchingOfPlayersWithTrainers
{
    /// <summary>
    ///     Matches players from <paramref name="players" /> to trainers from <paramref name="trainers" /> so that a
    ///     player is matched to a trainer whose capability is at least the player's ability, maximizing the number of
    ///     matched pairs.
    /// </summary>
    /// <param name="players">The array of player ability values.</param>
    /// <param name="trainers">The array of trainer capability values.</param>
    /// <returns>The maximum number of players that can be matched with a trainer.</returns>
    int MatchPlayersAndTrainers(int[] players, int[] trainers);
}