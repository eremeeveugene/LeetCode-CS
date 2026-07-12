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

namespace LeetCode.Algorithms.IsSubsequence;

/// <summary>
///     https://leetcode.com/problems/is-subsequence/
/// </summary>
public interface IIsSubsequence
{
    /// <summary>
    ///     Determines whether <paramref name="s" /> is a subsequence of <paramref name="t" />.
    /// </summary>
    /// <param name="s">The candidate subsequence.</param>
    /// <param name="t">The string to check against.</param>
    /// <returns><c>true</c> if <paramref name="s" /> is a subsequence of <paramref name="t" />; otherwise, <c>false</c>.</returns>
    bool IsSubsequence(string s, string t);
}