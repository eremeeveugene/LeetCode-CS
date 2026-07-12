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

namespace LeetCode.Algorithms.ExtraCharactersInString;

/// <summary>
///     https://leetcode.com/problems/extra-characters-in-a-string/description/
/// </summary>
public interface IExtraCharactersInString
{
    /// <summary>
    ///     Computes the minimum number of extra characters left over when <paramref name="s" /> is optimally broken into
    ///     non-overlapping substrings present in <paramref name="dictionary" />.
    /// </summary>
    /// <param name="s">The string to break into substrings.</param>
    /// <param name="dictionary">The array of dictionary words.</param>
    /// <returns>The minimum number of extra characters left over.</returns>
    int MinExtraChar(string s, string[] dictionary);
}