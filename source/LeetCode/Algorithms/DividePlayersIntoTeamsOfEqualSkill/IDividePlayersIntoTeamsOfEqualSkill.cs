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

namespace LeetCode.Algorithms.DividePlayersIntoTeamsOfEqualSkill;

/// <summary>
///     https://leetcode.com/problems/divide-players-into-teams-of-equal-skill/description/
/// </summary>
public interface IDividePlayersIntoTeamsOfEqualSkill
{
    /// <summary>
    ///     Pairs up the players in <paramref name="skill" /> into teams of two with equal total skill, computing the sum
    ///     of the skill chemistry (product of skills) of each team.
    /// </summary>
    /// <param name="skill">The array of player skill values, with an even number of players.</param>
    /// <returns>The sum of the skill chemistry values for all teams, or -1 if the players cannot be paired equally.</returns>
    long DividePlayers(int[] skill);
}