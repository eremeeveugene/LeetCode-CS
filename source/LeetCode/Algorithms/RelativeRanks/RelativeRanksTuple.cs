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
public class RelativeRanksTuple : IRelativeRanks
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="score"></param>
    /// <returns></returns>
    public string[] FindRelativeRanks(int[] score)
    {
        var result = new string[score.Length];

        (int index, int score)[] tuples = new (int, int)[score.Length];

        for (var i = 0; i < score.Length; i++)
        {
            tuples[i] = (i, score[i]);
        }

        Array.Sort(tuples, (a, b) => b.score.CompareTo(a.score));

        for (var i = 0; i < tuples.Length; i++)
        {
            result[tuples[i].index] = i switch
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