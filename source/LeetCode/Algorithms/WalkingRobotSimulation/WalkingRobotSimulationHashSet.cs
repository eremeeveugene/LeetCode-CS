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

namespace LeetCode.Algorithms.WalkingRobotSimulation;

/// <inheritdoc />
public class WalkingRobotSimulationHashSet : IWalkingRobotSimulation
{
    /// <summary>
    ///     Time complexity - O(m + n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="commands"></param>
    /// <param name="obstacles"></param>
    /// <returns></returns>
    public int RobotSim(int[] commands, int[][] obstacles)
    {
        var result = 0;

        var x = 0;
        var y = 0;

        var direction = 0;

        var obstaclesHashSet = new HashSet<(int, int)>();

        foreach (var obstacle in obstacles)
        {
            obstaclesHashSet.Add((obstacle[0], obstacle[1]));
        }

        foreach (var command in commands)
        {
            switch (command)
            {
                case -1:
                    direction++;

                    if (direction > 3)
                    {
                        direction = 0;
                    }

                    break;

                case -2:

                    direction--;

                    if (direction < 0)
                    {
                        direction = 3;
                    }

                    break;
                default:
                    var move = Move(direction, x, y, command, obstaclesHashSet);

                    x = move.X;
                    y = move.Y;

                    result = Math.Max(result, (x * x) + (y * y));

                    break;
            }
        }

        return result;
    }

    private static (int X, int Y) Move(int direction, int x, int y, int units,
        HashSet<(int, int)> obstaclesHashSet)
    {
        for (var i = 0; i < units; i++)
        {
            switch (direction)
            {
                case 0:
                    if (obstaclesHashSet.Contains((x, y + 1)))
                    {
                        return (x, y);
                    }

                    y++;
                    break;
                case 1:
                    if (obstaclesHashSet.Contains((x + 1, y)))
                    {
                        return (x, y);
                    }

                    x++;
                    break;
                case 2:
                    if (obstaclesHashSet.Contains((x, y - 1)))
                    {
                        return (x, y);
                    }

                    y--;
                    break;
                case 3:
                    if (obstaclesHashSet.Contains((x - 1, y)))
                    {
                        return (x, y);
                    }

                    x--;
                    break;
            }
        }

        return (x, y);
    }
}