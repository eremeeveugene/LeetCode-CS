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

namespace LeetCode.Algorithms.IsomorphicStrings;

/// <summary>
///     https://leetcode.com/problems/isomorphic-strings/description/
/// </summary>
public interface IIsomorphicStrings
{
    /// <summary>
    ///     Determines whether <paramref name="s" /> and <paramref name="t" /> are isomorphic, meaning the characters of
    ///     <paramref name="s" /> can be replaced to obtain <paramref name="t" /> while preserving character order.
    /// </summary>
    /// <param name="s">The first string.</param>
    /// <param name="t">The second string.</param>
    /// <returns><c>true</c> if the strings are isomorphic; otherwise, <c>false</c>.</returns>
    bool IsIsomorphic(string s, string t);
}