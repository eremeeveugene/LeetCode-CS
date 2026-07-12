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
public sealed class CountNegativeNumbersInSortedMatrixBruteForceBottomRight : ICountNegativeNumbersInSortedMatrix
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(1)
    /// </remarks>
    public int CountNegatives(int[][] grid)
    {
        var count = 0;

        var m = grid.Length;
        var n = grid[0].Length;

        for (var i = m - 1; i >= 0; i--)
        {
            for (var j = n - 1; j >= 0; j--)
            {
                if (grid[i][j] >= 0)
                {
                    break;
                }

                count++;
            }
        }

        return count;
    }
}