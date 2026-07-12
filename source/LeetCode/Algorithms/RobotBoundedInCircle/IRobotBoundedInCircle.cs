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

/// <summary>
///     https://leetcode.com/problems/robot-bounded-in-circle/description/
/// </summary>
public interface IRobotBoundedInCircle
{
    /// <summary>
    ///     Determines whether a robot repeatedly executing the movement <paramref name="instructions" /> on an infinite
    ///     plane stays confined within a bounded circle.
    /// </summary>
    /// <param name="instructions">The sequence of movement instructions ('G', 'L', or 'R') executed repeatedly.</param>
    /// <returns><see langword="true" /> if the robot's path is bounded in a circle; otherwise, <see langword="false" />.</returns>
    bool IsRobotBounded(string instructions);
}