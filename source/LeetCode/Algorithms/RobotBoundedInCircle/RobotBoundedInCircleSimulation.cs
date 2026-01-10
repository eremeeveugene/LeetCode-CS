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

namespace LeetCode.Algorithms.RobotBoundedInCircle;

/// <inheritdoc />
public sealed class RobotBoundedInCircleSimulation : IRobotBoundedInCircle
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="instructions"></param>
    /// <returns></returns>
    public bool IsRobotBounded(string instructions)
    {
        var direction = 0;

        var x = 0;
        var y = 0;

        foreach (var instruction in instructions)
        {
            switch (instruction)
            {
                case 'G':
                    switch (direction)
                    {
                        case 0:
                            y++;

                            break;
                        case 1:
                            x++;

                            break;
                        case 2:
                            y--;

                            break;
                        case 3:
                            x--;

                            break;
                    }

                    break;
                case 'L':
                    {
                        direction = (direction + 3) % 4;

                        break;
                    }
                case 'R':
                    {
                        direction = (direction + 1) % 4;

                        break;
                    }
            }
        }

        return (x == 0 && y == 0) || direction != 0;
    }
}