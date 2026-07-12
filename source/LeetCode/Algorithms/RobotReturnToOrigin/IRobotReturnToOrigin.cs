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

/// <summary>
///     https://leetcode.com/problems/robot-return-to-origin/description/
/// </summary>
public interface IRobotReturnToOrigin
{
    /// <summary>
    ///     Determines whether a robot that starts at the origin and executes the sequence of <paramref name="moves" />
    ///     returns to the origin.
    /// </summary>
    /// <param name="moves">The sequence of moves ('U', 'D', 'L', or 'R') executed by the robot.</param>
    /// <returns><see langword="true" /> if the robot returns to the origin; otherwise, <see langword="false" />.</returns>
    bool JudgeCircle(string moves);
}