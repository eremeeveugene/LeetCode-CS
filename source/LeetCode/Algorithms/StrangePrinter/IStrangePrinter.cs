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

namespace LeetCode.Algorithms.StrangePrinter;

/// <summary>
///     https://leetcode.com/problems/strange-printer/
/// </summary>
public interface IStrangePrinter
{
    /// <summary>
    ///     Computes the minimum number of turns a printer that prints a contiguous sequence of the same
    ///     character, possibly overlapping previously printed characters, needs to print <paramref name="s" />.
    /// </summary>
    /// <param name="s">The string to print.</param>
    /// <returns>The minimum number of turns needed to print <paramref name="s" />.</returns>
    int StrangePrinter(string s);
}