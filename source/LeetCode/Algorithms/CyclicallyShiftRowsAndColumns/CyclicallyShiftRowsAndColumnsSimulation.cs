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
public sealed class CyclicallyShiftRowsAndColumnsSimulation : ICyclicallyShiftRowsAndColumns
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    public int[][] CyclicShift(int n, int[][] grid, int[] rowShift, int[] colShift)
    {
        var result = new int[n][];

        for (var row = 0; row < n; row++)
        {
            result[row] = new int[n];

            for (var column = 0; column < n; column++)
            {
                var sourceRow = (row + colShift[column]) % n;
                var sourceColumn = (column + rowShift[sourceRow]) % n;

                result[row][column] = grid[sourceRow][sourceColumn];
            }
        }

        return result;
    }
}