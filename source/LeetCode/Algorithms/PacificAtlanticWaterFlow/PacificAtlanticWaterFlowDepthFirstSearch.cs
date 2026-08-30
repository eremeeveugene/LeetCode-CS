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

namespace LeetCode.Algorithms.PacificAtlanticWaterFlow;

/// <inheritdoc />
public sealed class PacificAtlanticWaterFlowDepthFirstSearch : IPacificAtlanticWaterFlow
{
    private const byte PacificOcean = 1;
    private const byte AtlanticOcean = 2;
    private const byte BothOceans = PacificOcean + AtlanticOcean;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m * n)
    /// </remarks>
    public IList<IList<int>> PacificAtlantic(int[][] heights)
    {
        var m = heights.Length;
        var n = heights[0].Length;

        var cellCount = m * n;

        Span<byte> reachability = stackalloc byte[cellCount];

        for (var row = 0; row < m; row++)
        {
            MarkReachableCells(heights, reachability, row, 0, PacificOcean, m, n);
            MarkReachableCells(heights, reachability, row, n - 1, AtlanticOcean, m, n);
        }

        for (var column = 0; column < n; column++)
        {
            MarkReachableCells(heights, reachability, 0, column, PacificOcean, m, n);
            MarkReachableCells(heights, reachability, m - 1, column, AtlanticOcean, m, n);
        }

        var result = new List<IList<int>>(cellCount);

        for (var row = 0; row < m; row++)
        {
            for (var column = 0; column < n; column++)
            {
                var cellIndex = GetCellIndex(row, column, n);

                if (reachability[cellIndex] != BothOceans)
                {
                    continue;
                }

                result.Add(new[] { row, column });
            }
        }

        return result;
    }

    /// <summary>
    ///     Marks every cell reachable from the specified ocean by recursively traversing to adjacent cells of equal or greater height.
    /// </summary>
    /// <remarks>
    ///     Each cell is processed at most once for the specified ocean.
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m * n) in the worst case for the recursion stack
    /// </remarks>
    /// <param name="heights">The matrix of cell heights.</param>
    /// <param name="reachability">The row-major buffer recording ocean reachability flags.</param>
    /// <param name="row">The current cell row.</param>
    /// <param name="column">The current cell column.</param>
    /// <param name="ocean">The flag identifying the ocean being traversed.</param>
    /// <param name="m">The number of rows in <paramref name="heights" />.</param>
    /// <param name="n">The number of columns in <paramref name="heights" />.</param>
    private static void MarkReachableCells(int[][] heights, Span<byte> reachability, int row, int column, byte ocean, int m, int n)
    {
        var cellIndex = GetCellIndex(row, column, n);

        if ((reachability[cellIndex] & ocean) == ocean)
        {
            return;
        }

        reachability[cellIndex] += ocean;

        var height = heights[row][column];

        if (row > 0 && heights[row - 1][column] >= height)
        {
            MarkReachableCells(heights, reachability, row - 1, column, ocean, m, n);
        }

        if (row < m - 1 && heights[row + 1][column] >= height)
        {
            MarkReachableCells(heights, reachability, row + 1, column, ocean, m, n);
        }

        if (column > 0 && heights[row][column - 1] >= height)
        {
            MarkReachableCells(heights, reachability, row, column - 1, ocean, m, n);
        }

        if (column < n - 1 && heights[row][column + 1] >= height)
        {
            MarkReachableCells(heights, reachability, row, column + 1, ocean, m, n);
        }
    }

    /// <summary>
    ///     Converts a cell's two-dimensional coordinates to its index in a row-major buffer.
    /// </summary>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    /// <param name="row">The cell row.</param>
    /// <param name="column">The cell column.</param>
    /// <param name="columnCount">The number of columns in the grid.</param>
    /// <returns>The cell index in the flattened buffer.</returns>
    private static int GetCellIndex(int row, int column, int columnCount)
    {
        return (row * columnCount) + column;
    }
}