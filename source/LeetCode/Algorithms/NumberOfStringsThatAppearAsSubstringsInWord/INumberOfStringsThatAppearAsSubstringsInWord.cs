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

namespace LeetCode.Algorithms.NumberOfStringsThatAppearAsSubstringsInWord;

/// <summary>
///     https://leetcode.com/problems/number-of-strings-that-appear-as-substrings-in-word/description/
/// </summary>
public interface INumberOfStringsThatAppearAsSubstringsInWord
{
    /// <summary>
    ///     Counts how many strings in <paramref name="patterns" /> appear as a substring of <paramref name="word" />.
    /// </summary>
    /// <param name="patterns">The array of pattern strings to look for in <paramref name="word" />.</param>
    /// <param name="word">The string in which the patterns are searched.</param>
    /// <returns>The number of strings in <paramref name="patterns" /> that exist as a substring of <paramref name="word" />.</returns>
    int NumOfStrings(string[] patterns, string word);
}