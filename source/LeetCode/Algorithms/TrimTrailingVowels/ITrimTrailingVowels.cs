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

namespace LeetCode.Algorithms.TrimTrailingVowels;

/// <summary>
///     https://leetcode.com/problems/trim-trailing-vowels/description/
/// </summary>
public interface ITrimTrailingVowels
{
    /// <summary>
    ///     Removes all trailing vowels from the end of <paramref name="s" />.
    /// </summary>
    /// <param name="s">The string to trim.</param>
    /// <returns>The string with all trailing vowels removed.</returns>
    string TrimTrailingVowels(string s);
}