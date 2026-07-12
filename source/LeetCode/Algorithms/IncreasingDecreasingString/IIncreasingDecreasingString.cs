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

namespace LeetCode.Algorithms.IncreasingDecreasingString;

/// <summary>
///     https://leetcode.com/problems/increasing-decreasing-string/
/// </summary>
public interface IIncreasingDecreasingString
{
    /// <summary>
    ///     Reorders the characters of <paramref name="s" /> by repeatedly picking the smallest-to-largest distinct
    ///     characters followed by the largest-to-smallest distinct characters until all characters are used.
    /// </summary>
    /// <param name="s">The string to reorder.</param>
    /// <returns>The resulting string after the reordering algorithm.</returns>
    string SortString(string s);
}