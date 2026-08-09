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

namespace LeetCode.Algorithms.CheckIfThereIsValidPathInGrid;

/// <inheritdoc />
public sealed class CheckIfThereIsValidPathInGridSimulation : ICheckIfThereIsValidPathInGrid
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m * n)
    /// </remarks>
    public bool HasValidPath(int[][] grid)
    {
        var rowCount = grid.Length;
        var columnCount = grid[0].Length;

        if (rowCount == 1 && columnCount == 1)
        {
            return true;
        }

        var length = rowCount * columnCount;

        Span<int> visited = stackalloc int[length];

        return HasValidPath(grid, visited, 1, 0, 0, 0, 1) || HasValidPath(grid, visited, 2, 0, 0, 1, 0);
    }

    private static bool HasValidPath(int[][] grid, Span<int> visited, int stamp, int row, int column, int rowOffset, int columnOffset)
    {
        if (!CanMove(grid[row][column], rowOffset, columnOffset))
        {
            return false;
        }

        var rowCount = grid.Length;
        var columnCount = grid[0].Length;

        while (row != rowCount - 1 || column != columnCount - 1)
        {
            visited[(row * columnCount) + column] = stamp;

            var incomingRowOffset = -rowOffset;
            var incomingColumnOffset = -columnOffset;

            row += rowOffset;
            column += columnOffset;

            if (row < 0 || row >= rowCount || column < 0 || column >= columnCount || visited[(row * columnCount) + column] == stamp)
            {
                return false;
            }

            var street = grid[row][column];

            if (!CanMove(street, incomingRowOffset, incomingColumnOffset))
            {
                return false;
            }

            GetNextOffset(street, incomingRowOffset, incomingColumnOffset, out rowOffset, out columnOffset);
        }

        return true;
    }

    private static bool CanMove(int street, int rowOffset, int columnOffset)
    {
        return street switch
        {
            1 => rowOffset == 0 && columnOffset != 0,
            2 => columnOffset == 0 && rowOffset != 0,
            3 => columnOffset == -1 || rowOffset == 1,
            4 => columnOffset == 1 || rowOffset == 1,
            5 => columnOffset == -1 || rowOffset == -1,
            6 => columnOffset == 1 || rowOffset == -1,
            _ => false
        };
    }

    private static void GetNextOffset(int street, int incomingRowOffset, int incomingColumnOffset, out int rowOffset, out int columnOffset)
    {
        switch (street)
        {
            case 1:
                rowOffset = 0;
                columnOffset = -incomingColumnOffset;
                break;

            case 2:
                rowOffset = -incomingRowOffset;
                columnOffset = 0;
                break;

            case 3:
                (rowOffset, columnOffset) = GetCurveOffset(incomingColumnOffset, -1, 1, -1);
                break;

            case 4:
                (rowOffset, columnOffset) = GetCurveOffset(incomingColumnOffset, 1, 1, 1);
                break;

            case 5:
                (rowOffset, columnOffset) = GetCurveOffset(incomingColumnOffset, -1, -1, -1);
                break;

            default:
                (rowOffset, columnOffset) = GetCurveOffset(incomingColumnOffset, 1, -1, 1);
                break;
        }
    }

    private static (int RowOffset, int ColumnOffset) GetCurveOffset(
        int incomingColumnOffset,
        int matchingColumnOffset,
        int turnRowOffset,
        int fallbackColumnOffset)
    {
        return incomingColumnOffset == matchingColumnOffset ? (turnRowOffset, 0) : (0, fallbackColumnOffset);
    }
}