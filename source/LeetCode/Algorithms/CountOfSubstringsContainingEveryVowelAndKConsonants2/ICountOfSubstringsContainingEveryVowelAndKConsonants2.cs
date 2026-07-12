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

namespace LeetCode.Algorithms.CountOfSubstringsContainingEveryVowelAndKConsonants2;

/// <summary>
///     https://leetcode.com/problems/count-of-substrings-containing-every-vowel-and-k-consonants-ii/description/
/// </summary>
public interface ICountOfSubstringsContainingEveryVowelAndKConsonants2
{
    /// <summary>
    ///     Counts the substrings of <paramref name="word" /> that contain all five vowels at least once and exactly
    ///     <paramref name="k" /> consonants.
    /// </summary>
    /// <param name="word">The string consisting of lowercase English letters.</param>
    /// <param name="k">The exact number of consonants required in a qualifying substring.</param>
    /// <returns>The total number of substrings satisfying the vowel and consonant conditions.</returns>
    long CountOfSubstrings(string word, int k);
}