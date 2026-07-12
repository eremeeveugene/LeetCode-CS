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
public sealed class DesignNeighborSumServiceDictionary : IDesignNeighborSumService
{
    private readonly int[][] _grid;
    private readonly Dictionary<int, (int X, int Y)> _neighborsDictionary = [];

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="grid"></param>
    public DesignNeighborSumServiceDictionary(int[][] grid)
    {
        _grid = grid;

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                _neighborsDictionary.Add(grid[i][j], (i, j));
            }
        }
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public int AdjacentSum(int value)
    {
        var (x, y) = _neighborsDictionary[value];

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
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public int DiagonalSum(int value)
    {
        var (x, y) = _neighborsDictionary[value];

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
}