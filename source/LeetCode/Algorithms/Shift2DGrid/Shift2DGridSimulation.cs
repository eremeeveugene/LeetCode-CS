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

namespace LeetCode.Algorithms.Shift2DGrid;

/// <inheritdoc />
public sealed class Shift2DGridSimulation : IShift2DGrid
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m * n)
    /// </remarks>
    public IList<IList<int>> ShiftGrid(int[][] grid, int k)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        var total = m * n;

        var shift = k % total;

        var result = new List<IList<int>>(m);

        for (var i = 0; i < m; i++)
        {
            result[i] = new List<int>(n);

            for (var j = 0; j < n; j++)
            {
                var source = ((i * n) + j - shift + total) % total;

                var sourceI = source / m;
                var sourceJ = source % n;

                result[i][j] = grid[sourceI][sourceJ];
            }
        }

        return result;
    }
}