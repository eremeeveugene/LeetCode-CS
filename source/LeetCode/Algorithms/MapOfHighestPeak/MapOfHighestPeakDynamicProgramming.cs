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

namespace LeetCode.Algorithms.MapOfHighestPeak;

/// <inheritdoc />
public sealed class MapOfHighestPeakDynamicProgramming : IMapOfHighestPeak
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int[][] HighestPeak(int[][] isWater)
    {
        var m = isWater.Length;
        var n = isWater[0].Length;

        var infinity = m + n;

        InitializeHeights(isWater, m, n, infinity);
        RelaxFromTopLeft(isWater, m, n, infinity);
        RelaxFromBottomRight(isWater, m, n, infinity);

        return isWater;
    }

    private static void InitializeHeights(int[][] heights, int m, int n, int infinity)
    {
        for (var row = 0; row < m; row++)
        {
            for (var col = 0; col < n; col++)
            {
                heights[row][col] = heights[row][col] == 1 ? 0 : infinity;
            }
        }
    }

    private static void RelaxFromTopLeft(int[][] heights, int m, int n, int infinity)
    {
        for (var row = 0; row < m; row++)
        {
            for (var col = 0; col < n; col++)
            {
                if (heights[row][col] == 0)
                {
                    continue;
                }

                var up = row > 0 ? heights[row - 1][col] : infinity;
                var left = col > 0 ? heights[row][col - 1] : infinity;

                heights[row][col] = int.Min(up, left) + 1;
            }
        }
    }

    private static void RelaxFromBottomRight(int[][] heights, int m, int n, int infinity)
    {
        for (var row = m - 1; row >= 0; row--)
        {
            for (var col = n - 1; col >= 0; col--)
            {
                if (heights[row][col] == 0)
                {
                    continue;
                }

                var down = row < m - 1 ? heights[row + 1][col] : infinity;
                var right = col < n - 1 ? heights[row][col + 1] : infinity;

                heights[row][col] = int.Min(heights[row][col], int.Min(down, right) + 1);
            }
        }
    }
}