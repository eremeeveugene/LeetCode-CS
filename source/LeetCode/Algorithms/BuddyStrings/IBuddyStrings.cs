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

namespace LeetCode.Algorithms.BuddyStrings;

/// <summary>
///     https://leetcode.com/problems/buddy-strings/description/
/// </summary>
public interface IBuddyStrings
{
    /// <summary>
    ///     Determines whether swapping exactly two letters in <paramref name="s" /> can make it equal to
    ///     <paramref name="goal" />.
    /// </summary>
    /// <param name="s">The source string.</param>
    /// <param name="goal">The target string.</param>
    /// <returns><c>true</c> if a single swap of two letters in <paramref name="s" /> yields <paramref name="goal" />; otherwise, <c>false</c>.</returns>
    bool BuddyStrings(string s, string goal);
}