// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.FindTheMinimumAreaToCoverAllOnes2;

/// <inheritdoc />
public class FindTheMinimumAreaToCoverAllOnes2BruteForce : IFindTheMinimumAreaToCoverAllOnes2
{
    private const int EmptyArea = int.MaxValue / 3;

    /// <summary>
    ///     Time complexity - O(m^2 * n^2)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public int MinimumSum(int[][] grid)
    {
        var rowCount = grid.Length;
        var columnCount = grid[0].Length;

        var minimumSum = EmptyArea;

        minimumSum = Math.Min(minimumSum, MinimumTopBandThenBottomSplitByColumn(grid, rowCount, columnCount));
        minimumSum = Math.Min(minimumSum, MinimumTopSplitByColumnThenBottomBand(grid, rowCount, columnCount));
        minimumSum = Math.Min(minimumSum, MinimumThreeHorizontalBands(grid, rowCount, columnCount));
        minimumSum = Math.Min(minimumSum, MinimumLeftBandThenRightSplitByRow(grid, rowCount, columnCount));
        minimumSum = Math.Min(minimumSum, MinimumLeftSplitByRowThenRightBand(grid, rowCount, columnCount));
        minimumSum = Math.Min(minimumSum, MinimumThreeVerticalBands(grid, rowCount, columnCount));

        return minimumSum;
    }

    private static int MinimumTopBandThenBottomSplitByColumn(int[][] grid, int rowCount, int columnCount)
    {
        var minimumSum = EmptyArea;

        for (var topEnd = 0; topEnd < rowCount - 1; topEnd++)
        {
            for (var splitColumn = 0; splitColumn < columnCount - 1; splitColumn++)
            {
                var currentSum = 0;

                currentSum += MinimumArea(grid, rowCount, columnCount, 0, topEnd, 0, columnCount - 1);
                currentSum += MinimumArea(grid, rowCount, columnCount, topEnd + 1, rowCount - 1, 0, splitColumn);
                currentSum += MinimumArea(grid, rowCount, columnCount, topEnd + 1, rowCount - 1, splitColumn + 1,
                    columnCount - 1);

                if (currentSum < minimumSum)
                {
                    minimumSum = currentSum;
                }
            }
        }

        return minimumSum;
    }

    private static int MinimumTopSplitByColumnThenBottomBand(int[][] grid, int rowCount, int columnCount)
    {
        var minimumSum = EmptyArea;

        for (var topEnd = 0; topEnd < rowCount - 1; topEnd++)
        {
            for (var splitColumn = 0; splitColumn < columnCount - 1; splitColumn++)
            {
                var currentSum = 0;

                currentSum += MinimumArea(grid, rowCount, columnCount, 0, topEnd, 0, splitColumn);
                currentSum += MinimumArea(grid, rowCount, columnCount, 0, topEnd, splitColumn + 1, columnCount - 1);
                currentSum += MinimumArea(grid, rowCount, columnCount, topEnd + 1, rowCount - 1, 0,
                    columnCount - 1);

                if (currentSum < minimumSum)
                {
                    minimumSum = currentSum;
                }
            }
        }

        return minimumSum;
    }

    private static int MinimumThreeHorizontalBands(int[][] grid, int rowCount, int columnCount)
    {
        var minimumSum = EmptyArea;

        for (var topEnd = 0; topEnd < rowCount - 2; topEnd++)
        {
            for (var midEnd = topEnd + 1; midEnd < rowCount - 1; midEnd++)
            {
                var currentSum = 0;

                currentSum += MinimumArea(grid, rowCount, columnCount, 0, topEnd, 0, columnCount - 1);
                currentSum += MinimumArea(grid, rowCount, columnCount, topEnd + 1, midEnd, 0, columnCount - 1);
                currentSum += MinimumArea(grid, rowCount, columnCount, midEnd + 1, rowCount - 1, 0, columnCount - 1);

                if (currentSum < minimumSum)
                {
                    minimumSum = currentSum;
                }
            }
        }

        return minimumSum;
    }

    private static int MinimumLeftBandThenRightSplitByRow(int[][] grid, int rowCount, int columnCount)
    {
        var minimumSum = EmptyArea;

        for (var leftEnd = 0; leftEnd < columnCount - 1; leftEnd++)
        {
            for (var splitRow = 0; splitRow < rowCount - 1; splitRow++)
            {
                var currentSum = 0;

                currentSum += MinimumArea(grid, rowCount, columnCount, 0, rowCount - 1, 0, leftEnd);
                currentSum += MinimumArea(grid, rowCount, columnCount, 0, splitRow, leftEnd + 1, columnCount - 1);
                currentSum += MinimumArea(grid, rowCount, columnCount, splitRow + 1, rowCount - 1, leftEnd + 1,
                    columnCount - 1);

                if (currentSum < minimumSum)
                {
                    minimumSum = currentSum;
                }
            }
        }

        return minimumSum;
    }

    private static int MinimumLeftSplitByRowThenRightBand(int[][] grid, int rowCount, int columnCount)
    {
        var minimumSum = EmptyArea;

        for (var leftEnd = 0; leftEnd < columnCount - 1; leftEnd++)
        {
            for (var splitRow = 0; splitRow < rowCount - 1; splitRow++)
            {
                var currentSum = 0;

                currentSum += MinimumArea(grid, rowCount, columnCount, 0, splitRow, 0, leftEnd);
                currentSum += MinimumArea(grid, rowCount, columnCount, splitRow + 1, rowCount - 1, 0, leftEnd);
                currentSum += MinimumArea(grid, rowCount, columnCount, 0, rowCount - 1, leftEnd + 1,
                    columnCount - 1);

                if (currentSum < minimumSum)
                {
                    minimumSum = currentSum;
                }
            }
        }

        return minimumSum;
    }

    private static int MinimumThreeVerticalBands(int[][] grid, int rowCount, int columnCount)
    {
        var minimumSum = EmptyArea;

        for (var leftEnd = 0; leftEnd < columnCount - 2; leftEnd++)
        {
            for (var midEnd = leftEnd + 1; midEnd < columnCount - 1; midEnd++)
            {
                var currentSum = 0;

                currentSum += MinimumArea(grid, rowCount, columnCount, 0, rowCount - 1, 0, leftEnd);
                currentSum += MinimumArea(grid, rowCount, columnCount, 0, rowCount - 1, leftEnd + 1, midEnd);
                currentSum += MinimumArea(grid, rowCount, columnCount, 0, rowCount - 1, midEnd + 1, columnCount - 1);

                if (currentSum < minimumSum)
                {
                    minimumSum = currentSum;
                }
            }
        }

        return minimumSum;
    }

    private static int MinimumArea(
        int[][] grid,
        int rowCount,
        int columnCount,
        int rowStart,
        int rowEnd,
        int columnStart,
        int columnEnd)
    {
        var minRow = rowCount;
        var maxRow = 0;
        var minColumn = columnCount;
        var maxColumn = 0;

        for (var row = rowStart; row <= rowEnd; row++)
        {
            for (var column = columnStart; column <= columnEnd; column++)
            {
                if (grid[row][column] == 0)
                {
                    continue;
                }

                if (row < minRow)
                {
                    minRow = row;
                }

                if (row > maxRow)
                {
                    maxRow = row;
                }

                if (column < minColumn)
                {
                    minColumn = column;
                }

                if (column > maxColumn)
                {
                    maxColumn = column;
                }
            }
        }

        if (maxRow < minRow)
        {
            return EmptyArea;
        }

        return (maxRow - minRow + 1) * (maxColumn - minColumn + 1);
    }
}