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

namespace LeetCode.Algorithms.MinimumNumberOfMovesToSeatEveryone;

/// <summary>
///     https://leetcode.com/problems/minimum-number-of-moves-to-seat-everyone/
/// </summary>
public interface IMinimumNumberOfMovesToSeatEveryone
{
    /// <summary>
    ///     Finds the minimum total number of moves needed to seat every student in <paramref name="students" /> at a
    ///     distinct seat position from <paramref name="seats" />, moving one position per move.
    /// </summary>
    /// <param name="seats">The array of seat positions.</param>
    /// <param name="students">The array of student positions.</param>
    /// <returns>The minimum total number of moves required to seat all students.</returns>
    int MinMovesToSeat(int[] seats, int[] students);
}