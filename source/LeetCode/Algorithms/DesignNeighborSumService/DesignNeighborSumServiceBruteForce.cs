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
public sealed class DesignNeighborSumServiceBruteForce : DesignNeighborSumServiceBase
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
    public override int AdjacentSum(int value)
    {
        var (x, y) = FindPosition(value);

        return GetAdjacentSum(_grid, x, y);
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </remarks>
    public override int DiagonalSum(int value)
    {
        var (x, y) = FindPosition(value);

        return GetDiagonalSum(_grid, x, y);
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