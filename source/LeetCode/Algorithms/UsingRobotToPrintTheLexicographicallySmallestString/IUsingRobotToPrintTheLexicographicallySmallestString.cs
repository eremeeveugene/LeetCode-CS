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

namespace LeetCode.Algorithms.UsingRobotToPrintTheLexicographicallySmallestString;

/// <summary>
///     https://leetcode.com/problems/using-a-robot-to-print-the-lexicographically-smallest-string/description/
/// </summary>
public interface IUsingRobotToPrintTheLexicographicallySmallestString
{
    /// <summary>
    ///     Uses a robot with a stack to process each character of <paramref name="s" /> in order — pushing to the
    ///     stack or popping to the output — to build the lexicographically smallest possible resulting string.
    /// </summary>
    /// <param name="s">The string of lowercase English letters to process.</param>
    /// <returns>The lexicographically smallest string obtainable through the robot's stack operations.</returns>
    string RobotWithString(string s);
}