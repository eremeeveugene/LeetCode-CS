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
public abstract class DesignNeighborSumServiceBase : IDesignNeighborSumService
{
    /// <inheritdoc />
    public abstract int AdjacentSum(int value);

    /// <inheritdoc />
    public abstract int DiagonalSum(int value);

    /// <summary>
    ///     Computes the sum of the values in cells that share an edge with the cell at <paramref name="x" /> and
    ///     <paramref name="y" />.
    /// </summary>
    /// <param name="grid">The grid of distinct integer values.</param>
    /// <param name="x">The row of the cell.</param>
    /// <param name="y">The column of the cell.</param>
    /// <returns>The sum of the values in the edge-adjacent neighboring cells.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    protected static int GetAdjacentSum(int[][] grid, int x, int y)
    {
        var sum = 0;

        if (x > 0)
        {
            sum += grid[x - 1][y];
        }

        if (x < grid.Length - 1)
        {
            sum += grid[x + 1][y];
        }

        if (y > 0)
        {
            sum += grid[x][y - 1];
        }

        if (y < grid[x].Length - 1)
        {
            sum += grid[x][y + 1];
        }

        return sum;
    }

    /// <summary>
    ///     Computes the sum of the values in cells that share a corner (diagonal) with the cell at <paramref name="x" />
    ///     and <paramref name="y" />.
    /// </summary>
    /// <param name="grid">The grid of distinct integer values.</param>
    /// <param name="x">The row of the cell.</param>
    /// <param name="y">The column of the cell.</param>
    /// <returns>The sum of the values in the diagonally neighboring cells.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    protected static int GetDiagonalSum(int[][] grid, int x, int y)
    {
        var sum = 0;

        if (x > 0 && y > 0)
        {
            sum += grid[x - 1][y - 1];
        }

        if (x > 0 && y < grid[x].Length - 1)
        {
            sum += grid[x - 1][y + 1];
        }

        if (x < grid.Length - 1 && y > 0)
        {
            sum += grid[x + 1][y - 1];
        }

        if (x < grid.Length - 1 && y < grid[x].Length - 1)
        {
            sum += grid[x + 1][y + 1];
        }

        return sum;
    }
}