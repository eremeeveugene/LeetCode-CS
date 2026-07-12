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

namespace LeetCode.Algorithms.AppendCharactersToStringToMakeSubsequence;

/// <summary>
///     https://leetcode.com/problems/append-characters-to-string-to-make-subsequence/description/
/// </summary>
public interface IAppendCharactersToStringToMakeSubsequence
{
    /// <summary>
    ///     Computes the minimum number of characters that must be appended to the end of <paramref name="s" /> so that
    ///     <paramref name="t" /> becomes a subsequence of <paramref name="s" />.
    /// </summary>
    /// <param name="s">The string to append characters to.</param>
    /// <param name="t">The string that must become a subsequence.</param>
    /// <returns>The minimum number of characters to append to <paramref name="s" />.</returns>
    int AppendCharacters(string s, string t);
}