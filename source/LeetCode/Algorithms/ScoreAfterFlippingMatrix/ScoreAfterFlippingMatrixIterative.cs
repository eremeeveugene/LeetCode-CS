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

namespace LeetCode.Algorithms.ScoreAfterFlippingMatrix;

/// <inheritdoc />
public class ScoreAfterFlippingMatrixIterative : IScoreAfterFlippingMatrix
{
    /// <summary>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public int MatrixScore(int[][] grid)
    {
        foreach (var row in grid)
        {
            if (row[0] != 0)
            {
                continue;
            }

            for (var j = 0; j < row.Length; j++)
            {
                if (row[j] == 0)
                {
                    row[j] = 1;
                }
                else
                {
                    row[j] = 0;
                }
            }
        }

        for (var j = 1; j < grid[0].Length; j++)
        {
            var countOfOnes = grid.Count(row => row[j] == 1);

            if (countOfOnes >= grid.Length / 2.0)
            {
                continue;
            }

            foreach (var row in grid)
            {
                if (row[j] == 0)
                {
                    row[j] = 1;
                }
                else
                {
                    row[j] = 0;
                }
            }
        }

        var score = 0;

        foreach (var row in grid)
        {
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