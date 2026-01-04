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

namespace LeetCode.Algorithms.MinimumCostToMakeAtLeastOneValidPathInGrid;

/// <inheritdoc />
public class MinimumCostToMakeAtLeastOneValidPathInGridBreadthFirstSearch : IMinimumCostToMakeAtLeastOneValidPathInGrid
{
    private readonly (int X, int Y)[] _directions =
    [
        (0, 1),
        (0, -1),
        (1, 0),
        (-1, 0)
    ];

    /// <summary>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(n * m)
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public int MinCost(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        var cost = new int[m, n];

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                cost[i, j] = int.MaxValue;
            }
        }

        cost[0, 0] = 0;

        var linkedList = new LinkedList<(int X, int Y, int CurrentCost)>();

        linkedList.AddFirst((0, 0, 0));

        while (linkedList.First != null)
        {
            var (x, y, currentCost) = linkedList.First.Value;

            linkedList.RemoveFirst();

            if (currentCost > cost[x, y])
            {
                continue;
            }

            for (var d = 0; d < _directions.Length; d++)
            {
                var nx = x + _directions[d].X;
                var ny = y + _directions[d].Y;

                var newCost = currentCost;

                if (grid[x][y] != d + 1)
                {
                    newCost++;
                }

                if (nx < 0 || ny < 0 || nx >= m || ny >= n || newCost >= cost[nx, ny])
                {
                    continue;
                }

                cost[nx, ny] = newCost;

                if (grid[x][y] == d + 1)
                {
                    linkedList.AddFirst((nx, ny, newCost));
                }
                else
                {
                    linkedList.AddLast((nx, ny, newCost));
                }
            }
        }

        return cost[m - 1, n - 1];
    }
}