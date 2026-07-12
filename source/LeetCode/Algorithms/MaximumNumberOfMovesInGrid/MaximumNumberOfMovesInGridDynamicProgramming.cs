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

namespace LeetCode.Algorithms.MaximumNumberOfMovesInGrid;

/// <inheritdoc />
public sealed class MaximumNumberOfMovesInGridDynamicProgramming : IMaximumNumberOfMovesInGrid
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m), where n is number of rows and m is the number of columns
    ///     Space complexity - O(n), where n is number of rows
    /// </remarks>
    public int MaxMoves(int[][] grid)
    {
        var memoGrid = new int[grid.Length][];

        for (var i = 0; i < grid.Length; i++)
        {
            memoGrid[i] = new int[grid[i].Length];
        }

        var maxMoves = 0;

        for (var i = 0; i < grid.Length; i++)
        {
            maxMoves = Math.Max(maxMoves, MaxMoves(grid, memoGrid, i, 0));
        }

        return maxMoves;
    }

    private static int MaxMoves(int[][] grid, int[][] memoGrid, int i, int j)
    {
        var maxMoves = 0;

        if (memoGrid[i][j] != 0)
        {
            return memoGrid[i][j];
        }

        if (i - 1 >= 0 && j + 1 < grid[i].Length && grid[i - 1][j + 1] > grid[i][j])
        {
            maxMoves = Math.Max(maxMoves, MaxMoves(grid, memoGrid, i - 1, j + 1) + 1);
        }

        if (j + 1 < grid[i].Length && grid[i][j + 1] > grid[i][j])
        {
            maxMoves = Math.Max(maxMoves, MaxMoves(grid, memoGrid, i, j + 1) + 1);
        }

        if (i + 1 < grid.Length && j + 1 < grid[i].Length && grid[i + 1][j + 1] > grid[i][j])
        {
            maxMoves = Math.Max(maxMoves, MaxMoves(grid, memoGrid, i + 1, j + 1) + 1);
        }

        memoGrid[i][j] = maxMoves;

        return maxMoves;
    }
}