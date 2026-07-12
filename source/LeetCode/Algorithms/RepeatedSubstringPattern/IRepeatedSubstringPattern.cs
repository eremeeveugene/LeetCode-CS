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

namespace LeetCode.Algorithms.RepeatedSubstringPattern;

/// <summary>
///     https://leetcode.com/problems/repeated-substring-pattern/
/// </summary>
public interface IRepeatedSubstringPattern
{
    /// <summary>
    ///     Determines whether <paramref name="s" /> can be constructed by repeating one of its substrings multiple times.
    /// </summary>
    /// <param name="s">The string to evaluate.</param>
    /// <returns><see langword="true" /> if <paramref name="s" /> is composed of a repeated substring; otherwise, <see langword="false" />.</returns>
    bool RepeatedSubstringPattern(string s);
}