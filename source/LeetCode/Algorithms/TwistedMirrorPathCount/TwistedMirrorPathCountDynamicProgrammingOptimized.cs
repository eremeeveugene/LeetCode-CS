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

namespace LeetCode.Algorithms.TwistedMirrorPathCount;

/// <inheritdoc />
public sealed class TwistedMirrorPathCountDynamicProgrammingOptimized : ITwistedMirrorPathCount
{
    private const int Modulo = 1_000_000_007;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int UniquePaths(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        Span<int> downCounts = stackalloc int[n];

        for (var i = 0; i < m; i++)
        {
            var row = grid[i];

            var rightCount = i == 0 ? 1 : 0;

            for (var j = 0; j < n; j++)
            {
                var cell = row[j];

                var downCount = downCounts[j];

                if (cell == 1)
                {
                    downCounts[j] = rightCount;
                    rightCount = downCount;

                    continue;
                }

                var count = (rightCount + downCount) % Modulo;

                downCounts[j] = count;
                rightCount = count;
            }
        }

        return downCounts[n - 1];
    }
}