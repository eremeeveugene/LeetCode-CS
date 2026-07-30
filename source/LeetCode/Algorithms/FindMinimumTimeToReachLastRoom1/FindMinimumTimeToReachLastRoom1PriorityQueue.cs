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

namespace LeetCode.Algorithms.FindMinimumTimeToReachLastRoom1;

/// <inheritdoc />
public sealed class FindMinimumTimeToReachLastRoom1PriorityQueue : IFindMinimumTimeToReachLastRoom1
{
    private static readonly (int X, int Y)[] Directions = [(1, 0), (-1, 0), (0, 1), (0, -1)];

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m * log(n * m))
    ///     Space complexity - O(n * m)
    /// </remarks>
    public int MinTimeToReach(int[][] moveTime)
    {
        var n = moveTime.Length;
        var m = moveTime[0].Length;

        var visited = new int[n, m];

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                visited[i, j] = int.MaxValue;
            }
        }

        visited[0, 0] = 0;

        var priorityQueue = new PriorityQueue<(int X, int Y, int Time), int>();

        priorityQueue.Enqueue((0, 0, 0), 0);

        var result = 0;

        while (priorityQueue.Count > 0)
        {
            var item = priorityQueue.Dequeue();

            if (item.X == n - 1 && item.Y == m - 1)
            {
                result = item.Time;

                break;
            }

            foreach (var direction in Directions)
            {
                var targetX = item.X + direction.X;
                var targetY = item.Y + direction.Y;

                if (targetX < 0 || targetX >= n || targetY < 0 || targetY >= m)
                {
                    continue;
                }

                var targetTime = Math.Max(item.Time, moveTime[targetX][targetY]) + 1;

                if (targetTime >= visited[targetX, targetY])
                {
                    continue;
                }

                visited[targetX, targetY] = targetTime;

                priorityQueue.Enqueue((targetX, targetY, targetTime), targetTime);
            }
        }

        return result;
    }
}