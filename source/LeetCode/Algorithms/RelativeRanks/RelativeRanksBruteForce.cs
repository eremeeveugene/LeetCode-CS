// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.RelativeRanks;

/// <inheritdoc />
public class RelativeRanksBruteForce : IRelativeRanks
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="score"></param>
    /// <returns></returns>
    public string[] FindRelativeRanks(int[] score)
    {
        var result = new string[score.Length];

        var orderedScores = score.OrderByDescending(s => s).ToArray();

        for (var i = 0; i < orderedScores.Length; i++)
        {
            var resultIndex = Array.IndexOf(score, orderedScores[i]);

            result[resultIndex] = i switch
            {
                0 => "Gold Medal",
                1 => "Silver Medal",
                2 => "Bronze Medal",
                _ => (i + 1).ToString()
            };
        }

        return result;
    }
}