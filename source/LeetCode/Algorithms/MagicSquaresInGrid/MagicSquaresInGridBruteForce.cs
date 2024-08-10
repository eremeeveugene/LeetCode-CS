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

namespace LeetCode.Algorithms.MagicSquaresInGrid;

/// <inheritdoc />
public class MagicSquaresInGridBruteForce : IMagicSquaresInGrid
{
    /// <summary>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public int NumMagicSquaresInside(int[][] grid)
    {
        var result = 0;

        for (var i = 0; i < grid.Length - 2; i++)
        {
            for (var j = 0; j < grid[i].Length - 2; j++)
            {
                if (IsMagicSquare(grid, i, j))
                {
                    result++;
                }
            }
        }

        return result;
    }

    private static bool IsMagicSquare(IReadOnlyList<int[]> grid, int i, int j)
    {
        if (grid[i + 1][j + 1] != 5 || grid[i + 1][j + 1] == grid[i][j + 1] || grid[i + 1][j + 1] == grid[i + 1][j])
        {
            return false;
        }

        const int sum = 15;

        for (var k = 0; k < 3; k++)
        {
            var rowSum = 0;
            var columnSum = 0;

            for (var l = 0; l < 3; l++)
            {
                if (grid[i + k][j + l] > 9)
                {
                    return false;
                }

                rowSum += grid[i + k][j + l];
                columnSum += grid[i + l][j + k];
            }

            if (rowSum != sum || columnSum != sum)
            {
                return false;
            }
        }

        var leftDiagonalSum = 0;
        var rightDiagonalSum = 0;

        for (var k = 0; k < 3; k++)
        {
            leftDiagonalSum += grid[i + k][j + k];
            rightDiagonalSum += grid[i + k][2 + j - k];
        }

        return leftDiagonalSum == sum && rightDiagonalSum == sum;
    }
}