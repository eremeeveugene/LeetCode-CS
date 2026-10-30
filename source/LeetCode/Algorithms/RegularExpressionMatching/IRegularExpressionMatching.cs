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

namespace LeetCode.Algorithms.RegularExpressionMatching;

/// <summary>
///     https://leetcode.com/problems/regular-expression-matching/description/
/// </summary>
public interface IRegularExpressionMatching
{
    /// <summary>
    ///     Determines whether the pattern <paramref name="p" /> matches the entire string <paramref name="s" />, where
    ///     <c>'.'</c> matches any single character and <c>'*'</c> matches zero or more of the preceding element.
    /// </summary>
    /// <param name="s">The input string consisting of lowercase English letters.</param>
    /// <param name="p">The pattern consisting of lowercase English letters, <c>'.'</c>, and <c>'*'</c>.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="p" /> matches the entire <paramref name="s" />; otherwise,
    ///     <see langword="false" />.
    /// </returns>
    bool IsMatch(string s, string p);
}