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

namespace LeetCode.Algorithms.WalkingRobotSimulation;

/// <summary>
///     https://leetcode.com/problems/walking-robot-simulation/description/
/// </summary>
public interface IWalkingRobotSimulation
{
    /// <summary>
    ///     Simulates a robot executing the movement <paramref name="commands" /> on an infinite grid, stopping
    ///     before any cell listed in <paramref name="obstacles" />, and computes the maximum squared Euclidean
    ///     distance from the origin reached during the simulation.
    /// </summary>
    /// <param name="commands">The sequence of commands: -2 to turn left, -1 to turn right, or 1-9 to move forward that many units.</param>
    /// <param name="obstacles">The array of obstacle coordinates that block the robot's movement.</param>
    /// <returns>The maximum squared Euclidean distance from the origin achieved during the simulation.</returns>
    int RobotSim(int[] commands, int[][] obstacles);
}