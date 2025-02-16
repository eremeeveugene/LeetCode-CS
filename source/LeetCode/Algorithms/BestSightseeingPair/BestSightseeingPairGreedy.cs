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

namespace LeetCode.Algorithms.BestSightseeingPair;

/// <inheritdoc />
public class BestSightseeingPairGreedy : IBestSightseeingPair
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="values"></param>
    /// <returns></returns>
    public int MaxScoreSightseeingPair(int[] values)
    {
        var maxScore = 0;
        var maxSeen = values[0] + 0;

        for (var j = 1; j < values.Length; j++)
        {
            maxScore = Math.Max(maxScore, maxSeen + values[j] - j);

            maxSeen = Math.Max(maxSeen, values[j] + j);
        }

        return maxScore;
    }
}