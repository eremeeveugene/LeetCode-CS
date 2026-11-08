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

namespace LeetCode.Algorithms.ScoreValidator;

/// <summary>
///     https://leetcode.com/problems/score-validator/description/
/// </summary>
public interface IScoreValidator
{
    /// <summary>
    ///     Processes the events from left to right until all are processed or the counter reaches 10.
    /// </summary>
    /// <param name="events">The events, each one of "0", "1", "2", "3", "4", "6", "W", "WD" or "NB".</param>
    /// <returns>An array of two elements: the final score and the final counter.</returns>
    int[] ScoreValidator(string[] events);
}