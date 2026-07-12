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

namespace LeetCode.Algorithms.ButtonWithLongestPushTime;

/// <summary>
///     https://leetcode.com/problems/button-with-longest-push-time/description/
/// </summary>
public interface IButtonWithLongestPushTime
{
    /// <summary>
    ///     Finds the button that took the longest time to push, where the push time of a button is the difference between
    ///     its press time and the previous press time.
    /// </summary>
    /// <param name="events">The press events, where each event is a pair of button index and press time.</param>
    /// <returns>The index of the button with the longest push time, or the smallest index if there is a tie.</returns>
    int ButtonWithLongestTime(int[][] events);
}