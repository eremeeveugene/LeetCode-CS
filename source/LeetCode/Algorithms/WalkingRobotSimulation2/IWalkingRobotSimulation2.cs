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

namespace LeetCode.Algorithms.WalkingRobotSimulation2;

/// <summary>
///     https://leetcode.com/problems/walking-robot-simulation-ii/description/
/// </summary>
public interface IWalkingRobotSimulation2
{
    /// <summary>
    ///     Moves the robot forward <paramref name="num" /> steps, turning counterclockwise when out of bounds.
    /// </summary>
    /// <param name="num">The number of steps to move.</param>
    void Step(int num);

    /// <summary>
    ///     Returns the robot's current position as <c>[x, y]</c>.
    /// </summary>
    int[] GetPos();

    /// <summary>
    ///     Returns the robot's current facing direction.
    /// </summary>
    string GetDir();
}