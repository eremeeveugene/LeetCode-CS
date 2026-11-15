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
public sealed class MakeASquareWithTheSameColorCounting : IMakeASquareWithTheSameColor
{
    private const char Black = 'B';
    private const int SquareSize = 2;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool CanMakeSquare(char[][] grid)
    {
        var n = grid.Length;

        for (var topRow = 0; topRow <= n - SquareSize; topRow++)
        {
            for (var leftColumn = 0; leftColumn <= n - SquareSize; leftColumn++)
            {
                var blackCellsCount = CountBlackCells(grid, topRow, leftColumn);

                if (blackCellsCount != SquareSize)
                {
                    return true;
                }
            }
        }

        return false;
    }

    /// <summary>
    ///     Counts the black cells of the 2 x 2 square whose top-left cell is at <paramref name="topRow" /> and
    ///     <paramref name="leftColumn" />.
    /// </summary>
    /// <param name="grid">The matrix consisting only of the characters 'B' (black) and 'W' (white).</param>
    /// <param name="topRow">The row index of the top-left cell of the square.</param>
    /// <param name="leftColumn">The column index of the top-left cell of the square.</param>
    /// <returns>The number of black cells in the square.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static int CountBlackCells(char[][] grid, int topRow, int leftColumn)
    {
        var blackCellsCount = 0;

        for (var row = topRow; row < topRow + SquareSize; row++)
        {
            var cells = grid[row];

            for (var column = leftColumn; column < leftColumn + SquareSize; column++)
            {
                var cell = cells[column];

                if (cell == Black)
                {
                    blackCellsCount++;
                }
            }
        }

        return blackCellsCount;
    }
}