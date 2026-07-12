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

namespace LeetCode.Algorithms.FindMostFrequentVowelAndConsonant;

/// <summary>
///     https://leetcode.com/problems/find-most-frequent-vowel-and-consonant/description/
/// </summary>
public interface IFindMostFrequentVowelAndConsonant
{
    /// <summary>
    ///     Computes the sum of the maximum vowel frequency and the maximum consonant frequency in <paramref name="s" />.
    /// </summary>
    /// <param name="s">The string of lowercase English letters.</param>
    /// <returns>The sum of the frequencies of the most frequent vowel and the most frequent consonant.</returns>
    int MaxFreqSum(string s);
}