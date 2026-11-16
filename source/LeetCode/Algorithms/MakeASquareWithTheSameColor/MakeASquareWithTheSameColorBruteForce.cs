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

namespace LeetCode.Algorithms.MakeASquareWithTheSameColor;

/// <inheritdoc />
public sealed class MakeASquareWithTheSameColorBruteForce : IMakeASquareWithTheSameColor
{
    private const char Black = 'B';
    private const char White = 'W';
    private const int SquareSize = 2;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool CanMakeSquare(char[][] grid)
    {
        var hasSameColorSquare = HasSameColorSquare(grid);

        if (hasSameColorSquare)
        {
            return true;
        }

        var n = grid.Length;

        for (var row = 0; row < n; row++)
        {
            var cells = grid[row];

            for (var column = 0; column < n; column++)
            {
                FlipCell(cells, column);

                var hasSameColorSquareAfterChange = HasSameColorSquare(grid);

                FlipCell(cells, column);

                if (hasSameColorSquareAfterChange)
                {
                    return true;
                }
            }
        }

        return false;
    }

    /// <summary>
    ///     Flips the color of the cell at <paramref name="column" /> in <paramref name="cells" /> from 'B' (black) to
    ///     'W' (white) or vice versa.
    /// </summary>
    /// <param name="cells">The row of the grid containing the cell to flip.</param>
    /// <param name="column">The column index of the cell to flip.</param>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static void FlipCell(char[] cells, int column)
    {
        var cell = cells[column];

        cells[column] = cell == Black ? White : Black;
    }

    /// <summary>
    ///     Determines whether <paramref name="grid" /> contains a 2 x 2 square where all cells have the same color.
    /// </summary>
    /// <param name="grid">The matrix consisting only of the characters 'B' (black) and 'W' (white).</param>
    /// <returns><see langword="true" /> if such a 2 x 2 square exists; otherwise, <see langword="false" />.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static bool HasSameColorSquare(char[][] grid)
    {
        var n = grid.Length;

        for (var topRow = 0; topRow <= n - SquareSize; topRow++)
        {
            for (var leftColumn = 0; leftColumn <= n - SquareSize; leftColumn++)
            {
                var isSameColorSquare = IsSameColorSquare(grid, topRow, leftColumn);

                if (isSameColorSquare)
                {
                    return true;
                }
            }
        }

        return false;
    }

    /// <summary>
    ///     Determines whether all cells of the 2 x 2 square whose top-left cell is at <paramref name="topRow" /> and
    ///     <paramref name="leftColumn" /> have the same color.
    /// </summary>
    /// <param name="grid">The matrix consisting only of the characters 'B' (black) and 'W' (white).</param>
    /// <param name="topRow">The row index of the top-left cell of the square.</param>
    /// <param name="leftColumn">The column index of the top-left cell of the square.</param>
    /// <returns><see langword="true" /> if all cells of the square have the same color; otherwise, <see langword="false" />.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static bool IsSameColorSquare(char[][] grid, int topRow, int leftColumn)
    {
        var color = grid[topRow][leftColumn];

        for (var row = topRow; row < topRow + SquareSize; row++)
        {
            var cells = grid[row];

            for (var column = leftColumn; column < leftColumn + SquareSize; column++)
            {
                var cell = cells[column];

                if (cell != color)
                {
                    return false;
                }
            }
        }

        return true;
    }
}