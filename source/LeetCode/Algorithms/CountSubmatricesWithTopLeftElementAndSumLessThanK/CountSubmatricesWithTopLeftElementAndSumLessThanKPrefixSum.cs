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

namespace LeetCode.Algorithms.CountSubmatricesWithTopLeftElementAndSumLessThanK;

/// <inheritdoc />
public sealed class CountSubmatricesWithTopLeftElementAndSumLessThanKPrefixSum : ICountSubmatricesWithTopLeftElementAndSumLessThanK
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m), where n is the number of rows and m is the number of columns
    ///     Space complexity - O(1)
    /// </remarks>
    public int CountSubmatrices(int[][] grid, int k)
    {
        var n = grid.Length;
        var m = grid[0].Length;

        var result = 0;

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                var top = i > 0 ? grid[i - 1][j] : 0;
                var left = j > 0 ? grid[i][j - 1] : 0;
                var topLeft = i > 0 && j > 0 ? grid[i - 1][j - 1] : 0;

                grid[i][j] += top + left - topLeft;

                if (grid[i][j] <= k)
                {
                    result++;
                }
            }
        }

        return result;
    }
}