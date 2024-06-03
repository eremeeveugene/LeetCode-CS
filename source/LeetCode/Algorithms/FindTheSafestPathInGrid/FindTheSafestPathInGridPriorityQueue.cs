// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.FindTheSafestPathInGrid;

/// <inheritdoc />
public class FindTheSafestPathInGridPriorityQueue : IFindTheSafestPathInGrid
{
    /// <summary>
    ///     Time complexity - O(n^2 log n^2)
    ///     Space complexity - O(n^2)
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public int MaximumSafenessFactor(IList<IList<int>> grid)
    {
        var n = grid.Count;

        var thieves = new List<(int, int)>();

        for (var r = 0; r < n; r++)
        {
            for (var c = 0; c < n; c++)
            {
                if (grid[r][c] == 1)
                {
                    thieves.Add((r, c));
                }
            }
        }

        var distance = new int[n][];

        for (var i = 0; i < n; i++)
        {
            distance[i] = new int[n];

            Array.Fill(distance[i], int.MaxValue);
        }

        var queue = new Queue<(int, int)>();

        foreach (var thief in thieves)
        {
            queue.Enqueue(thief);

            distance[thief.Item1][thief.Item2] = 0;
        }

        int[][] directions = [[0, 1], [1, 0], [0, -1], [-1, 0]];

        while (queue.Count > 0)
        {
            var (r, c) = queue.Dequeue();

            foreach (var dir in directions)
            {
                int nr = r + dir[0], nc = c + dir[1];

                if (nr < 0 || nr >= n || nc < 0 || nc >= n || distance[nr][nc] != int.MaxValue)
                {
                    continue;
                }

                distance[nr][nc] = distance[r][c] + 1;

                queue.Enqueue((nr, nc));
            }
        }

        var priorityQueue = new PriorityQueue<(int, int, int), int>(Comparer<int>.Create((a, b) => b - a));

        priorityQueue.Enqueue((distance[0][0], 0, 0), distance[0][0]);

        var visited = new bool[n][];

        for (var i = 0; i < n; i++)
        {
            visited[i] = new bool[n];
        }

        visited[0][0] = true;

        while (priorityQueue.Count > 0)
        {
            var (minDist, r, c) = priorityQueue.Dequeue();

            if (r == n - 1 && c == n - 1)
            {
                return minDist;
            }

            foreach (var dir in directions)
            {
                int nr = r + dir[0], nc = c + dir[1];

                if (nr < 0 || nr >= n || nc < 0 || nc >= n || visited[nr][nc])
                {
                    continue;
                }

                visited[nr][nc] = true;

                priorityQueue.Enqueue((Math.Min(minDist, distance[nr][nc]), nr, nc),
                    Math.Min(minDist, distance[nr][nc]));
            }
        }

        return 0;
    }
}