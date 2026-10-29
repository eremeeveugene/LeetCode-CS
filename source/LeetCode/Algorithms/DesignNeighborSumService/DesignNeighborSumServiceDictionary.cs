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
public sealed class DesignNeighborSumServiceDictionary : DesignNeighborSumServiceBase
{
    private readonly int[][] _grid;
    private readonly Dictionary<int, (int X, int Y)> _neighborsDictionary = [];

    /// <summary>
    ///     Initializes a new instance of the <see cref="DesignNeighborSumServiceDictionary" /> class.
    /// </summary>
    /// <param name="grid">The grid of distinct integer values.</param>
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
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
    public override int AdjacentSum(int value)
    {
        var (x, y) = _neighborsDictionary[value];

        return GetAdjacentSum(_grid, x, y);
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public override int DiagonalSum(int value)
    {
        var (x, y) = _neighborsDictionary[value];

        return GetDiagonalSum(_grid, x, y);
    }
}