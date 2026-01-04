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

namespace LeetCode.Algorithms.MagicSquaresInGrid;

/// <inheritdoc />
public class MagicSquaresInGridBruteForce : IMagicSquaresInGrid
{
    private const int MagicSquareSum = 15;

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
                if (!IsMagicSquare(grid, i, j))
                {
                    continue;
                }

                result++;
            }
        }

        return result;
    }

    private static bool IsMagicSquare(int[][] grid, int row, int column)
    {
        if (grid[row + 1][column + 1] != 5 ||
            grid[row + 1][column + 1] == grid[row][column + 1] ||
            grid[row + 1][column + 1] == grid[row + 1][column])
        {
            return false;
        }

        Span<bool> seen = stackalloc bool[10];

        for (var i = 0; i < 3; i++)
        {
            var rowSum = 0;
            var columnSum = 0;

            for (var j = 0; j < 3; j++)
            {
                var value = grid[row + i][column + j];

                if (value < 1 || value > 9 || seen[value])
                {
                    return false;
                }

                seen[value] = true;

                rowSum += value;
                columnSum += grid[row + j][column + i];
            }

            if (rowSum != MagicSquareSum || columnSum != MagicSquareSum)
            {
                return false;
            }
        }

        if (grid[row][column] + grid[row + 1][column + 1] + grid[row + 2][column + 2] != MagicSquareSum)
        {
            return false;
        }

        if (grid[row][column + 2] + grid[row + 1][column + 1] + grid[row + 2][column] != MagicSquareSum)
        {
            return false;
        }

        return true;
    }
}