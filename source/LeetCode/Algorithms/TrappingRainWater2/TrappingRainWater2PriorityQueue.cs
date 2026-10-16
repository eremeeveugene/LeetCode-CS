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

namespace LeetCode.Algorithms.TrappingRainWater2;

/// <inheritdoc />
public sealed class TrappingRainWater2PriorityQueue : ITrappingRainWater2
{
    private static readonly (int X, int Y)[] Directions = [(1, 0), (-1, 0), (0, 1), (0, -1)];

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m * log(n * m))
    ///     Space complexity - O(n * m)
    /// </remarks>
    public int TrapRainWater(int[][] heightMap)
    {
        var n = heightMap.Length;
        var m = heightMap[0].Length;

        if (n < 3 || m < 3)
        {
            return 0;
        }

        var visited = new bool[n, m];
        var priorityQueue = new PriorityQueue<(int X, int Y), int>();

        for (var j = 0; j < m; j++)
        {
            visited[0, j] = true;
            priorityQueue.Enqueue((0, j), heightMap[0][j]);

            visited[n - 1, j] = true;
            priorityQueue.Enqueue((n - 1, j), heightMap[n - 1][j]);
        }

        for (var i = 1; i < n - 1; i++)
        {
            visited[i, 0] = true;
            priorityQueue.Enqueue((i, 0), heightMap[i][0]);

            visited[i, m - 1] = true;
            priorityQueue.Enqueue((i, m - 1), heightMap[i][m - 1]);
        }

        var result = 0;

        while (priorityQueue.TryDequeue(out var cell, out var level))
        {
            for (var i = 0; i < Directions.Length; i++)
            {
                var direction = Directions[i];

                var targetX = cell.X + direction.X;
                var targetY = cell.Y + direction.Y;

                if (targetX < 0 || targetX >= n || targetY < 0 || targetY >= m || visited[targetX, targetY])
                {
                    continue;
                }

                visited[targetX, targetY] = true;

                var targetHeight = heightMap[targetX][targetY];

                result += Math.Max(0, level - targetHeight);

                priorityQueue.Enqueue((targetX, targetY), Math.Max(level, targetHeight));
            }
        }

        return result;
    }
}