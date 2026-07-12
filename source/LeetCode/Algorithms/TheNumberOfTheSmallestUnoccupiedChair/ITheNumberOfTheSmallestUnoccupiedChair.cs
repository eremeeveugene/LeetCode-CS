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

namespace LeetCode.Algorithms.TheNumberOfTheSmallestUnoccupiedChair;

/// <summary>
///     https://leetcode.com/problems/the-number-of-the-smallest-unoccupied-chair/description/
/// </summary>
public interface ITheNumberOfTheSmallestUnoccupiedChair
{
    /// <summary>
    ///     Simulates friends arriving and leaving according to the arrival and departure times in
    ///     <paramref name="times" />, each taking the smallest-numbered unoccupied chair, and returns the chair
    ///     number occupied by the friend at index <paramref name="targetFriend" />.
    /// </summary>
    /// <param name="times">The array of pairs of arrival and departure times for each friend.</param>
    /// <param name="targetFriend">The index of the friend whose chair number should be returned.</param>
    /// <returns>The chair number occupied by the friend at index <paramref name="targetFriend" />.</returns>
    int SmallestChair(int[][] times, int targetFriend);
}