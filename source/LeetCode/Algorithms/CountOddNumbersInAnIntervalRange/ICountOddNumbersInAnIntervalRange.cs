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

namespace LeetCode.Algorithms.CountOddNumbersInAnIntervalRange;

/// <summary>
///     https://leetcode.com/problems/count-odd-numbers-in-an-interval-range/description/
/// </summary>
public interface ICountOddNumbersInAnIntervalRange
{
    /// <summary>
    ///     Counts the odd numbers in the inclusive range from <paramref name="low" /> to <paramref name="high" />.
    /// </summary>
    /// <param name="low">The lower bound of the range.</param>
    /// <param name="high">The upper bound of the range.</param>
    /// <returns>The number of odd numbers between <paramref name="low" /> and <paramref name="high" /> inclusive.</returns>
    int CountOdds(int low, int high);
}