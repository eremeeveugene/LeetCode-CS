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

namespace LeetCode.Algorithms.LongestSquareStreakInAnArray;

/// <summary>
///     https://leetcode.com/problems/longest-square-streak-in-an-array/description/
/// </summary>
public interface ILongestSquareStreakInAnArray
{
    /// <summary>
    ///     Finds the length of the longest square streak in <paramref name="nums" />, where a square streak is a
    ///     sequence of numbers in which each element (except the first) is the square of the previous one.
    /// </summary>
    /// <param name="nums">The array of integers to search for a square streak.</param>
    /// <returns>The length of the longest square streak, or -1 if no such streak of length at least 2 exists.</returns>
    int LongestSquareStreak(int[] nums);
}