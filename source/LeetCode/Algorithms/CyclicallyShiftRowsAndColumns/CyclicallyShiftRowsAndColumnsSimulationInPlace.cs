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

namespace LeetCode.Algorithms.CyclicallyShiftRowsAndColumns;

/// <inheritdoc />
public sealed class CyclicallyShiftRowsAndColumnsSimulationInPlace : ICyclicallyShiftRowsAndColumns
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n^2)
    /// </remarks>
    public int[][] CyclicShift(int n, int[][] grid, int[] rowShift, int[] colShift)
    {
        var cellCount = n * n;

        Span<int> shiftedValues = stackalloc int[cellCount];

        for (var i = 0; i < cellCount; i++)
        {
            var row = i / n;
            var column = i % n;

            var sourceRow = (row + colShift[column]) % n;
            var sourceColumn = (column + rowShift[sourceRow]) % n;

            shiftedValues[i] = grid[sourceRow][sourceColumn];
        }

        for (var i = 0; i < cellCount; i++)
        {
            var row = i / n;
            var column = i % n;

            grid[row][column] = shiftedValues[i];
        }

        return grid;
    }
}