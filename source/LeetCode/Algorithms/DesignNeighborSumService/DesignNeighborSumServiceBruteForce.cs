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

namespace LeetCode.Algorithms.DesignNeighborSumService;

/// <inheritdoc />
public sealed class DesignNeighborSumServiceBruteForce : IDesignNeighborSumService
{
    private readonly int[][] _grid;

    public DesignNeighborSumServiceBruteForce(int[][] grid)
    {
        _grid = grid;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int AdjacentSum(int value)
    {
        var (x, y) = FindPosition(value);

        var sum = 0;

        if (x > 0)
        {
            sum += _grid[x - 1][y];
        }

        if (x < _grid.Length - 1)
        {
            sum += _grid[x + 1][y];
        }

        if (y > 0)
        {
            sum += _grid[x][y - 1];
        }

        if (y < _grid[x].Length - 1)
        {
            sum += _grid[x][y + 1];
        }

        return sum;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int DiagonalSum(int value)
    {
        var (x, y) = FindPosition(value);

        var sum = 0;

        if (x > 0 && y > 0)
        {
            sum += _grid[x - 1][y - 1];
        }

        if (x > 0 && y < _grid[x].Length - 1)
        {
            sum += _grid[x - 1][y + 1];
        }

        if (x < _grid.Length - 1 && y > 0)
        {
            sum += _grid[x + 1][y - 1];
        }

        if (x < _grid.Length - 1 && y < _grid.Length - 1)
        {
            sum += _grid[x + 1][y + 1];
        }

        return sum;
    }

    private (int X, int Y) FindPosition(int value)
    {
        (int X, int Y) position = (0, 0);

        for (var i = 0; i < _grid.Length; i++)
        {
            for (var j = 0; j < _grid[i].Length; j++)
            {
                if (_grid[i][j] == value)
                {
                    position = (i, j);
                }
            }
        }

        return position;
    }
}