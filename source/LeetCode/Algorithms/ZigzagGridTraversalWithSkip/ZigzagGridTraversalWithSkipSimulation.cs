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

namespace LeetCode.Algorithms.ZigzagGridTraversalWithSkip;

/// <inheritdoc />
public sealed class ZigzagGridTraversalWithSkipSimulation : IZigzagGridTraversalWithSkip
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n*m)
    ///     Space complexity - O(k)
    /// </remarks>
    public IList<int> ZigzagTraversal(int[][] grid)
    {
        var result = new List<int>();

        for (var i = 0; i < grid.Length; i++)
        {
            if (i % 2 == 0)
            {
                for (var j = 0; j < grid[i].Length; j += 2)
                {
                    result.Add(grid[i][j]);
                }
            }
            else
            {
                var start = grid[i].Length - 1;

                if (grid[i].Length % 2 == 1)
                {
                    start--;
                }

                for (var j = start; j >= 0; j -= 2)
                {
                    result.Add(grid[i][j]);
                }
            }
        }

        return result;
    }
}