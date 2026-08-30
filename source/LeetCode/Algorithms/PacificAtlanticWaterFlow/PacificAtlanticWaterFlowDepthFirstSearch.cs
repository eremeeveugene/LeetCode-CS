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
    private static readonly (int Row, int Column)[] Directions = [(1, 0), (-1, 0), (0, 1), (0, -1)];

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

        Span<bool> isPacificReachable = stackalloc bool[cellCount];
        Span<bool> isAtlanticReachable = stackalloc bool[cellCount];

        for (var row = 0; row < m; row++)
        {
            MarkReachableCells(heights, isPacificReachable, row, 0, m, n);
            MarkReachableCells(heights, isAtlanticReachable, row, n - 1, m, n);
        }

        for (var column = 0; column < n; column++)
        {
            MarkReachableCells(heights, isPacificReachable, 0, column, m, n);
            MarkReachableCells(heights, isAtlanticReachable, m - 1, column, m, n);
        }

        var result = new List<IList<int>>();

        for (var row = 0; row < m; row++)
        {
            for (var column = 0; column < n; column++)
            {
                var cellIndex = GetCellIndex(row, column, n);

                var canReachPacific = isPacificReachable[cellIndex];
                var canReachAtlantic = isAtlanticReachable[cellIndex];

                if (!canReachPacific || !canReachAtlantic)
                {
                    continue;
                }

                result.Add([row, column]);
            }
        }

        return result;
    }

    /// <summary>
    ///     Marks every cell reachable from the specified ocean by traversing from the current cell to adjacent cells of equal or greater height.
    /// </summary>
    /// <remarks>
    ///     Across all calls that share <paramref name="isReachable" />, each cell is processed at most once.
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m * n) in the worst case for the recursion stack
    /// </remarks>
    /// <param name="heights">The matrix of cell heights.</param>
    /// <param name="isReachable">The row-major buffer recording cells that can reach the current ocean.</param>
    /// <param name="row">The current row.</param>
    /// <param name="column">The current column.</param>
    /// <param name="m">The number of rows in <paramref name="heights" />.</param>
    /// <param name="n">The number of columns in <paramref name="heights" />.</param>
    private static void MarkReachableCells(int[][] heights, Span<bool> isReachable, int row, int column, int m, int n)
    {
        var cellIndex = GetCellIndex(row, column, n);

        if (isReachable[cellIndex])
        {
            return;
        }

        isReachable[cellIndex] = true;

        for (var i = 0; i < Directions.Length; i++)
        {
            var direction = Directions[i];

            var nextRow = row + direction.Row;
            var nextColumn = column + direction.Column;

            if (nextRow < 0 || nextColumn < 0 || nextRow >= m || nextColumn >= n || heights[nextRow][nextColumn] < heights[row][column])
            {
                continue;
            }

            MarkReachableCells(heights, isReachable, nextRow, nextColumn, m, n);
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