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
    ///     Moves the robot forward <paramref name="num" /> steps, rotating 90°
    ///     counterclockwise in place (without consuming a step) whenever the
    ///     next move would go out of bounds.
    /// </summary>
    /// <param name="num">The number of forward steps to take.</param>
    void Step(int num);

    /// <summary>
    ///     Returns the robot's current position as <c>[x, y]</c>.
    /// </summary>
    /// <returns>A two-element array containing the current <c>x</c> and <c>y</c> coordinates.</returns>
    int[] GetPos();

    /// <summary>
    ///     Returns the robot's current facing direction:
    ///     <c>"East"</c>, <c>"North"</c>, <c>"West"</c>, or <c>"South"</c>.
    /// </summary>
    /// <returns>The facing direction as a string.</returns>
    string GetDir();
}