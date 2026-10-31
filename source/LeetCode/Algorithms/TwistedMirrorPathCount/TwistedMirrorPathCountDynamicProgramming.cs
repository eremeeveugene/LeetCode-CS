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
public sealed class TwistedMirrorPathCountDynamicProgramming : ITwistedMirrorPathCount
{
    private const int Modulo = 1_000_000_007;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m * n)
    /// </remarks>
    public int UniquePaths(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        var dp = new int[m, n, 2];

        dp[0, 0, 0] = 1;

        for (var i = 0; i < m; i++)
        {
            var row = grid[i];

            for (var j = 0; j < n; j++)
            {
                var fromLeft = dp[i, j, 0];
                var fromTop = dp[i, j, 1];

                var isMirror = row[j] == 1;

                var count = (fromLeft + fromTop) % Modulo;

                var goRight = isMirror ? fromTop : count;
                var goDown = isMirror ? fromLeft : count;

                if (j + 1 < n)
                {
                    dp[i, j + 1, 0] = goRight;
                }

                if (i + 1 < m)
                {
                    dp[i + 1, j, 1] = goDown;
                }
            }
        }

        return (dp[m - 1, n - 1, 0] + dp[m - 1, n - 1, 1]) % Modulo;
    }
}