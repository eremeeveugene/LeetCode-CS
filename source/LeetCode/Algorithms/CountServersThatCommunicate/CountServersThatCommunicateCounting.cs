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

namespace LeetCode.Algorithms.CountServersThatCommunicate;

/// <inheritdoc />
public sealed class CountServersThatCommunicateCounting : ICountServersThatCommunicate
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m + n)
    /// </remarks>
    public int CountServers(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        var rowCount = new int[m];
        var colCount = new int[n];

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (grid[i][j] == 0)
                {
                    continue;
                }

                rowCount[i]++;
                colCount[j]++;
            }
        }

        var result = 0;

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (grid[i][j] == 1 && (rowCount[i] > 1 || colCount[j] > 1))
                {
                    result++;
                }
            }
        }

        return result;
    }
}