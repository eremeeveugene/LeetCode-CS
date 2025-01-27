// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.DesignNeighborSumService;

/// <inheritdoc />
public class DesignNeighborSumServiceBruteForce(int[][] grid) : IDesignNeighborSumService
{
    /// <summary>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public int AdjacentSum(int value)
    {
        var (x, y) = FindPosition(value);

        var sum = 0;

        if (x > 0)
        {
            sum += grid[x - 1][y];
        }

        if (x < grid.Length - 1)
        {
            sum += grid[x + 1][y];
        }

        if (y > 0)
        {
            sum += grid[x][y - 1];
        }

        if (y < grid[x].Length - 1)
        {
            sum += grid[x][y + 1];
        }

        return sum;
    }

    /// <summary>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public int DiagonalSum(int value)
    {
        var (x, y) = FindPosition(value);

        var sum = 0;

        if (x > 0 && y > 0)
        {
            sum += grid[x - 1][y - 1];
        }

        if (x > 0 && y < grid[x].Length - 1)
        {
            sum += grid[x - 1][y + 1];
        }

        if (x < grid.Length - 1 && y > 0)
        {
            sum += grid[x + 1][y - 1];
        }

        if (x < grid.Length - 1 && y < grid.Length - 1)
        {
            sum += grid[x + 1][y + 1];
        }

        return sum;
    }

    private (int X, int Y) FindPosition(int value)
    {
        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == value)
                {
                    return (i, j);
                }
            }
        }

        return (-1, -1);
    }
}