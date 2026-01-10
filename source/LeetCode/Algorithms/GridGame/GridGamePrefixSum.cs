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

namespace LeetCode.Algorithms.GridGame;

/// <inheritdoc />
public sealed class GridGamePrefixSum : IGridGame
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public long GridGame(int[][] grid)
    {
        var n = grid[0].Length;

        var topPrefixSum = new long[n];
        var bottomPrefixSum = new long[n];

        topPrefixSum[0] = grid[0][0];
        bottomPrefixSum[0] = grid[1][0];

        for (var i = 1; i < n; i++)
        {
            topPrefixSum[i] = topPrefixSum[i - 1] + grid[0][i];
            bottomPrefixSum[i] = bottomPrefixSum[i - 1] + grid[1][i];
        }

        var result = long.MaxValue;

        for (var i = 0; i < n; i++)
        {
            var topRemaining = topPrefixSum[n - 1] - topPrefixSum[i];

            long bottomCollected = 0;

            if (i > 0)
            {
                bottomCollected = bottomPrefixSum[i - 1];
            }

            var secondRobotPoints = Math.Max(topRemaining, bottomCollected);

            result = Math.Min(result, secondRobotPoints);
        }

        return result;
    }
}