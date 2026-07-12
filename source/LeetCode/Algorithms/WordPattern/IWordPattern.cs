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

namespace LeetCode.Algorithms.WordPattern;

/// <summary>
///     https://leetcode.com/problems/word-pattern/
/// </summary>
public interface IWordPattern
{
    /// <summary>
    ///     Determines whether <paramref name="s" /> follows the same bijective letter-to-word mapping described by
    ///     <paramref name="pattern" />.
    /// </summary>
    /// <param name="pattern">The pattern string of letters, each representing a distinct word.</param>
    /// <param name="s">The space-separated string of words to match against <paramref name="pattern" />.</param>
    /// <returns><see langword="true" /> if <paramref name="s" /> follows the same pattern; otherwise, <see langword="false" />.</returns>
    bool WordPattern(string pattern, string s);
}