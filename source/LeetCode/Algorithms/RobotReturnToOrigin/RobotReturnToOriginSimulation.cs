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

namespace LeetCode.Algorithms.RobotReturnToOrigin;

/// <inheritdoc />
public class RobotReturnToOriginSimulation : IRobotReturnToOrigin
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="moves"></param>
    /// <returns></returns>
    public bool JudgeCircle(string moves)
    {
        var x = 0;
        var y = 0;

        foreach (var move in moves)
        {
            switch (move)
            {
                case 'R':
                    x++;

                    break;
                case 'L':
                    x--;
                    break;
                case 'U':
                    y++;
                    break;
                case 'D':
                    y--;
                    break;
            }
        }

        return x == 0 && y == 0;
    }
}