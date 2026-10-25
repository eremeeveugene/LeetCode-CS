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

namespace LeetCode.Algorithms.CountDaysSpentTogether;

/// <summary>
///     https://leetcode.com/problems/count-days-spent-together/description/
/// </summary>
public interface ICountDaysSpentTogether
{
    /// <summary>
    ///     Counts the days of a non-leap year on which Alice and Bob are both in Rome.
    /// </summary>
    /// <param name="arriveAlice">The date Alice arrives, in the format "MM-DD".</param>
    /// <param name="leaveAlice">The date Alice leaves, in the format "MM-DD".</param>
    /// <param name="arriveBob">The date Bob arrives, in the format "MM-DD".</param>
    /// <param name="leaveBob">The date Bob leaves, in the format "MM-DD".</param>
    /// <returns>The total number of days Alice and Bob are in Rome together.</returns>
    int CountDaysTogether(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob);
}