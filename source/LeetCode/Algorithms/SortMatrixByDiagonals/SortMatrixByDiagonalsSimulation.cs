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

namespace LeetCode.Algorithms.SortMatrixByDiagonals;

/// <inheritdoc />
public class SortMatrixByDiagonalsSimulation : ISortMatrixByDiagonals
{
    /// <summary>
    ///     Time complexity - O(n^2 log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public int[][] SortMatrix(int[][] grid)
    {
        var n = grid.Length;

        if (n == 1)
        {
            return grid;
        }

        Span<int> items = stackalloc int[n * n];

        for (var i = 0; i < n - 1; i++)
        {
            var index = 0;

            for (var j = 0; i + j < n; j++)
            {
                items[index] = grid[i + j][j];

                index++;
            }

            items[..index].Sort((a, b) => b.CompareTo(a));

            for (var j = 0; j < index; j++)
            {
                grid[i + j][j] = items[j];
            }
        }

        for (var j = 1; j < n - 1; j++)
        {
            var index = 0;

            for (var i = 0; j + i < n; i++)
            {
                items[index] = grid[i][j + i];

                index++;
            }

            items[..index].Sort();

            for (var i = 0; i < index; i++)
            {
                grid[i][j + i] = items[i];
            }
        }

        return grid;
    }
}