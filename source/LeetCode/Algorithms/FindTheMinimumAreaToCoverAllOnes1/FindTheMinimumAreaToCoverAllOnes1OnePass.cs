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

namespace LeetCode.Algorithms.FindTheMinimumAreaToCoverAllOnes1;

/// <inheritdoc />
public class FindTheMinimumAreaToCoverAllOnes1OnePass : IFindTheMinimumAreaToCoverAllOnes1
{
    /// <summary>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public int MinimumArea(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        var top = m;
        var bottom = -1;
        var left = n;
        var right = -1;

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (grid[i][j] == 0)
                {
                    continue;
                }

                if (i < top)
                {
                    top = i;
                }

                if (i > bottom)
                {
                    bottom = i;
                }

                if (j < left)
                {
                    left = j;
                }

                if (j > right)
                {
                    right = j;
                }
            }
        }

        if (bottom < 0)
        {
            return 0;
        }

        return (right - left + 1) * (bottom - top + 1);
    }
}