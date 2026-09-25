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

namespace LeetCode.Algorithms.DesignExamScoresTracker;

/// <summary>
///     https://leetcode.com/problems/design-exam-scores-tracker/description/
/// </summary>
public interface IDesignExamScoresTracker
{
    /// <summary>
    ///     Records an exam score at a time strictly greater than all previously recorded times.
    /// </summary>
    /// <param name="time">The exam time.</param>
    /// <param name="score">The exam score.</param>
    void Record(int time, int score);

    /// <summary>
    ///     Returns the total score of exams within the inclusive time interval.
    /// </summary>
    /// <param name="startTime">The start of the interval.</param>
    /// <param name="endTime">The end of the interval, no later than the most recent exam.</param>
    /// <returns>The total score, or zero if the interval contains no exams.</returns>
    long TotalScore(int startTime, int endTime);
}