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

namespace LeetCode.Algorithms.SwimInRisingWater;

/// <inheritdoc />
public sealed class SwimInRisingWaterPriorityQueue : ISwimInRisingWater
{
    private static readonly (int X, int Y)[] Directions = [(-1, 0), (1, 0), (0, -1), (0, 1)];

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2 log(n))
    ///     Space complexity - O(n^2)
    /// </remarks>
    public int SwimInWater(int[][] grid)
    {
        var n = grid.Length;

        var minTimes = new int[n, n];

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                minTimes[i, j] = int.MaxValue;
            }
        }

        var startTime = grid[0][0];

        minTimes[0, 0] = startTime;

        var minTimePriorityQueue = new PriorityQueue<(int X, int Y), int>();

        minTimePriorityQueue.Enqueue((0, 0), startTime);

        while (minTimePriorityQueue.Count > 0)
        {
            var (x, y) = minTimePriorityQueue.Dequeue();

            if (x == n - 1 && y == n - 1)
            {
                break;
            }

            foreach (var direction in Directions)
            {
                var nextX = x + direction.X;
                var nextY = y + direction.Y;

                if (nextX < 0 || nextY < 0 || nextX >= n || nextY >= n)
                {
                    continue;
                }

                var nextTime = Math.Max(minTimes[x, y], grid[nextX][nextY]);

                if (nextTime >= minTimes[nextX, nextY])
                {
                    continue;
                }

                minTimes[nextX, nextY] = nextTime;

                minTimePriorityQueue.Enqueue((nextX, nextY), nextTime);
            }
        }

        return minTimes[n - 1, n - 1];
    }
}