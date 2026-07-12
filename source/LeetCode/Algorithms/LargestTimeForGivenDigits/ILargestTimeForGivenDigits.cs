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

namespace LeetCode.Algorithms.LargestTimeForGivenDigits;

/// <summary>
///     https://leetcode.com/problems/largest-time-for-given-digits/description/
/// </summary>
public interface ILargestTimeForGivenDigits
{
    /// <summary>
    ///     Finds the largest 24-hour time that can be formed by using all four digits in <paramref name="arr" /> exactly once.
    /// </summary>
    /// <param name="arr">The array of four digits to arrange into a time.</param>
    /// <returns>The largest valid time in "HH:MM" format, or an empty string if no valid time can be formed.</returns>
    string LargestTimeFromDigits(int[] arr);
}