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

namespace LeetCode.Algorithms.CountUnguardedCellsInTheGrid;

/// <inheritdoc />
public sealed class CountUnguardedCellsInTheGridSimulation : ICountUnguardedCellsInTheGrid
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m * n)
    /// </remarks>
    public int CountUnguarded(int m, int n, int[][] guards, int[][] walls)
    {
        var result = m * n;

        var cells = new int[m, n];

        foreach (var guard in guards)
        {
            var row = guard[0];
            var col = guard[1];

            cells[row, col] = 1;

            result--;
        }

        foreach (var wall in walls)
        {
            var row = wall[0];
            var col = wall[1];

            cells[row, col] = 2;

            result--;
        }

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (cells[i, j] == 1)
                {
                    result -= Mark(cells, m, n, i, j);
                }
            }
        }

        return result;
    }

    private static int Mark(int[,] cells, int m, int n, int x, int y)
    {
        return MarkDirection(cells, m, n, x, y, 1, 0) +
               MarkDirection(cells, m, n, x, y, -1, 0) +
               MarkDirection(cells, m, n, x, y, 0, 1) +
               MarkDirection(cells, m, n, x, y, 0, -1);
    }

    private static int MarkDirection(int[,] cells, int m, int n, int x, int y, int dx, int dy)
    {
        var result = 0;

        for (int i = x + dx, j = y + dy; i >= 0 && i < m && j >= 0 && j < n; i += dx, j += dy)
        {
            if (cells[i, j] == 2 || cells[i, j] == 1)
            {
                break;
            }

            if (cells[i, j] != 0)
            {
                continue;
            }

            cells[i, j] = -1;

            result++;
        }

        return result;
    }
}