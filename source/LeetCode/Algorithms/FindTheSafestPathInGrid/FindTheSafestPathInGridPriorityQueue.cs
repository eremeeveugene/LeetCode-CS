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

namespace LeetCode.Algorithms.FindTheSafestPathInGrid;

/// <inheritdoc />
public sealed class FindTheSafestPathInGridPriorityQueue : IFindTheSafestPathInGrid
{
    private static readonly (int Dr, int Dc)[] Directions = [(0, 1), (1, 0), (0, -1), (-1, 0)];

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2 log n^2)
    ///     Space complexity - O(n^2)
    /// </remarks>
    public int MaximumSafenessFactor(IList<IList<int>> grid)
    {
        var n = grid.Count;

        var distance = ComputeThiefDistances(grid, n);

        return FindMaximumSafeness(distance, n);
    }

    private static int[][] ComputeThiefDistances(IList<IList<int>> grid, int n)
    {
        var distance = new int[n][];

        for (var i = 0; i < n; i++)
        {
            distance[i] = new int[n];

            Array.Fill(distance[i], int.MaxValue);
        }

        var queue = new Queue<(int, int)>();

        for (var r = 0; r < n; r++)
        {
            for (var c = 0; c < n; c++)
            {
                if (grid[r][c] != 1)
                {
                    continue;
                }

                queue.Enqueue((r, c));

                distance[r][c] = 0;
            }
        }

        while (queue.Count > 0)
        {
            var (r, c) = queue.Dequeue();

            foreach (var (dr, dc) in Directions)
            {
                int nr = r + dr, nc = c + dc;

                if (IsOutsideGrid(nr, nc, n) || distance[nr][nc] != int.MaxValue)
                {
                    continue;
                }

                distance[nr][nc] = distance[r][c] + 1;

                queue.Enqueue((nr, nc));
            }
        }

        return distance;
    }

    private static int FindMaximumSafeness(int[][] distance, int n)
    {
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

            foreach (var (dr, dc) in Directions)
            {
                int nr = r + dr, nc = c + dc;

                if (IsOutsideGrid(nr, nc, n) || visited[nr][nc])
                {
                    continue;
                }

                visited[nr][nc] = true;

                var safeness = Math.Min(minDist, distance[nr][nc]);

                priorityQueue.Enqueue((safeness, nr, nc), safeness);
            }
        }

        return 0;
    }

    private static bool IsOutsideGrid(int r, int c, int n)
    {
        return r < 0 || r >= n || c < 0 || c >= n;
    }
}