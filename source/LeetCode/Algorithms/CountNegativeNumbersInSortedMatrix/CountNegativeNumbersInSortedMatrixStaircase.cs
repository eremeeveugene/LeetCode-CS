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
public sealed class CountNegativeNumbersInSortedMatrixStaircase : ICountNegativeNumbersInSortedMatrix
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(1)
    /// </remarks>
    public int CountNegatives(int[][] grid)
    {
        var count = 0;

        var m = grid.Length;
        var n = grid[0].Length;

        var i = 0;
        var j = n - 1;

        while (i < m && j >= 0)
        {
            if (grid[i][j] < 0)
            {
                count += m - i;

                j--;
            }
            else
            {
                i++;
            }
        }

        return count;
    }
}