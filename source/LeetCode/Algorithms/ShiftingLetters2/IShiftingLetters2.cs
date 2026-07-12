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

namespace LeetCode.Algorithms.ShiftingLetters2;

/// <summary>
///     https://leetcode.com/problems/shifting-letters-ii/description/
/// </summary>
public interface IShiftingLetters2
{
    /// <summary>
    ///     Applies each shift in <paramref name="shifts" /> to a range of characters in <paramref name="s" />,
    ///     cyclically shifting them forward or backward through the alphabet.
    /// </summary>
    /// <param name="s">The lowercase string to shift.</param>
    /// <param name="shifts">
    ///     The array of shift operations, each specifying a start index, end index, and direction.
    /// </param>
    /// <returns>The string <paramref name="s" /> after all shifts in <paramref name="shifts" /> are applied.</returns>
    string ShiftingLetters(string s, int[][] shifts);
}