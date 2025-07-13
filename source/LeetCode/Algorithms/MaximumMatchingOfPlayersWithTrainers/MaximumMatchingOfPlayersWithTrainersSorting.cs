// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.MaximumMatchingOfPlayersWithTrainers;

/// <inheritdoc />
public class MaximumMatchingOfPlayersWithTrainersSorting : IMaximumMatchingOfPlayersWithTrainers
{
    /// <summary>
    ///     Time complexity - O(n log n + m log m)
    ///     Space complexity - O(log n + log m)
    /// </summary>
    /// <param name="players"></param>
    /// <param name="trainers"></param>
    /// <returns></returns>
    public int MatchPlayersAndTrainers(int[] players, int[] trainers)
    {
        Array.Sort(players);
        Array.Sort(trainers);

        var playersIndex = 0;
        var trainersIndex = 0;

        while (playersIndex < players.Length && trainersIndex < trainers.Length)
        {
            if (players[playersIndex] <= trainers[trainersIndex])
            {
                playersIndex++;
            }

            trainersIndex++;
        }

        return playersIndex;
    }
}