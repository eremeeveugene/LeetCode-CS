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

namespace LeetCode.Algorithms.LexicographicallyMinimumStringAfterRemovingStars;

/// <summary>
///     https://leetcode.com/problems/lexicographically-minimum-string-after-removing-stars/description/
/// </summary>
public interface ILexicographicallyMinimumStringAfterRemovingStars
{
    /// <summary>
    ///     Repeatedly removes each '*' character in <paramref name="s" /> along with the smallest (lexicographically), closest preceding non-removed
    ///     character, choosing the deletion that yields the lexicographically smallest final string.
    /// </summary>
    /// <param name="s">The string containing lowercase letters and '*' characters to process.</param>
    /// <returns>The lexicographically smallest string obtainable after removing all '*' characters and their paired letters.</returns>
    string ClearStars(string s);
}