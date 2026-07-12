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

namespace LeetCode.Algorithms.CountNegativeNumbersInSortedMatrix;

/// <inheritdoc />
public sealed class CountNegativeNumbersInSortedMatrixBruteForceTopLeft : ICountNegativeNumbersInSortedMatrix
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(n * m)
    /// </remarks>
    public int CountNegatives(int[][] grid)
    {
        var count = 0;

        var m = grid.Length;
        var n = grid[0].Length;

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (grid[i][j] < 0)
                {
                    break;
                }

                count++;
            }
        }

        return (m * n) - count;
    }
}