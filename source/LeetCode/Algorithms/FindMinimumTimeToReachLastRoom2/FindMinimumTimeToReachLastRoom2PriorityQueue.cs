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

namespace LeetCode.Algorithms.FindMinimumTimeToReachLastRoom2;

/// <inheritdoc />
public sealed class FindMinimumTimeToReachLastRoom2PriorityQueue : IFindMinimumTimeToReachLastRoom2
{
    private static readonly (int X, int Y)[] Directions = [(1, 0), (-1, 0), (0, 1), (0, -1)];

    /// <summary>
    ///     Time complexity - O(n * m * log(n * m))
    ///     Space complexity - O(n * m)
    /// </summary>
    /// <param name="moveTime"></param>
    /// <returns></returns>
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

        var priorityQueue = new PriorityQueue<(int X, int Y, int Step, int Time), int>();

        priorityQueue.Enqueue((0, 0, 0, 0), 0);

        while (priorityQueue.Count > 0)
        {
            var item = priorityQueue.Dequeue();

            if (item.X == n - 1 && item.Y == m - 1)
            {
                return item.Time;
            }

            foreach (var direction in Directions)
            {
                var targetX = item.X + direction.X;
                var targetY = item.Y + direction.Y;

                if (targetX < 0 || targetX >= n || targetY < 0 || targetY >= m)
                {
                    continue;
                }

                var targetTime = Math.Max(item.Time, moveTime[targetX][targetY]) + (item.Step % 2 == 0 ? 1 : 2);

                if (targetTime >= visited[targetX, targetY])
                {
                    continue;
                }

                visited[targetX, targetY] = targetTime;

                priorityQueue.Enqueue((targetX, targetY, item.Step + 1, targetTime), targetTime);
            }
        }

        return -1;
    }
}