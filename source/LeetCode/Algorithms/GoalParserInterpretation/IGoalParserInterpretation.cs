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

namespace LeetCode.Algorithms.GoalParserInterpretation;

/// <summary>
///     https://leetcode.com/problems/goal-parser-interpretation/
/// </summary>
public interface IGoalParserInterpretation
{
    /// <summary>
    ///     Interprets <paramref name="command" /> by replacing "G" with "G", "()" with "o", and "(al)" with "al", and
    ///     concatenating the results in order.
    /// </summary>
    /// <param name="command">The command string consisting of "G", "()", and "(al)" tokens.</param>
    /// <returns>The interpreted string.</returns>
    string Interpret(string command);
}