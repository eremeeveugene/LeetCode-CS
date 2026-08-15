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

namespace LeetCode.Algorithms.ScoreAfterFlippingMatrix;

/// <inheritdoc />
public sealed class ScoreAfterFlippingMatrixIterative : IScoreAfterFlippingMatrix
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MatrixScore(int[][] grid)
    {
        FlipRowsStartingWithZero(grid);
        FlipColumnsWithFewerOnes(grid);

        return GetScore(grid);
    }

    private static void FlipRowsStartingWithZero(int[][] grid)
    {
        for (var i = 0; i < grid.Length; i++)
        {
            var row = grid[i];

            if (row[0] != 0)
            {
                continue;
            }

            for (var j = 0; j < row.Length; j++)
            {
                row[j] = row[j] == 0 ? 1 : 0;
            }
        }
    }

    private static void FlipColumnsWithFewerOnes(int[][] grid)
    {
        for (var j = 1; j < grid[0].Length; j++)
        {
            var countOfOnes = grid.Count(row => row[j] == 1);

            if (countOfOnes >= grid.Length / 2.0)
            {
                continue;
            }

            for (var i = 0; i < grid.Length; i++)
            {
                var row = grid[i];

                row[j] = row[j] == 0 ? 1 : 0;
            }
        }
    }

    private static int GetScore(int[][] grid)
    {
        var score = 0;

        for (var i = 0; i < grid.Length; i++)
        {
            var row = grid[i];

            for (var k = 0; k < row.Length; k++)
            {
                if (row[k] == 1)
                {
                    score += (int)Math.Pow(2, row.Length - 1 - k);
                }
            }
        }

        return score;
    }
}