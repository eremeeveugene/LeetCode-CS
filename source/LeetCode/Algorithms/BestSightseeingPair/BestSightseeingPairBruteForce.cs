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

namespace LeetCode.Algorithms.BestSightseeingPair;

/// <inheritdoc />
public sealed class BestSightseeingPairBruteForce : IBestSightseeingPair
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaxScoreSightseeingPair(int[] values)
    {
        var maxScore = 0;

        for (var i = 0; i < values.Length - 1; i++)
        {
            for (var j = i + 1; j < values.Length; j++)
            {
                maxScore = Math.Max(maxScore, values[i] + i + values[j] - j);
            }
        }

        return maxScore;
    }
}