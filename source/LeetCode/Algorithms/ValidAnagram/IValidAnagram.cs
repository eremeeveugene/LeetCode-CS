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

namespace LeetCode.Algorithms.ValidAnagram;

/// <summary>
///     https://leetcode.com/problems/valid-anagram/
/// </summary>
public interface IValidAnagram
{
    /// <summary>
    ///     Determines whether <paramref name="t" /> is an anagram of <paramref name="s" />.
    /// </summary>
    /// <param name="s">The first string.</param>
    /// <param name="t">The second string to compare against <paramref name="s" />.</param>
    /// <returns><see langword="true" /> if <paramref name="t" /> is an anagram of <paramref name="s" />; otherwise, <see langword="false" />.</returns>
    bool IsAnagram(string s, string t);
}