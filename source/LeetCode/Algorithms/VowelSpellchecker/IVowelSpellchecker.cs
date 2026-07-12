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

namespace LeetCode.Algorithms.VowelSpellchecker;

/// <summary>
///     https://leetcode.com/problems/vowel-spellchecker/description/
/// </summary>
public interface IVowelSpellchecker
{
    /// <summary>
    ///     Resolves each query in <paramref name="queries" /> to a matching entry in <paramref name="wordlist" />,
    ///     first by exact match, then case-insensitive match, then match after treating all vowels as
    ///     interchangeable.
    /// </summary>
    /// <param name="wordlist">The list of correctly spelled words used as the dictionary.</param>
    /// <param name="queries">The list of words to spellcheck against <paramref name="wordlist" />.</param>
    /// <returns>An array of correction results, one per query, or an empty string if no match is found.</returns>
    string[] Spellchecker(string[] wordlist, string[] queries);
}