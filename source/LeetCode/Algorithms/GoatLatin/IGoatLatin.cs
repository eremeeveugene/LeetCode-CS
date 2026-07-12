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

namespace LeetCode.Algorithms.GoatLatin;

/// <summary>
///     https://leetcode.com/problems/goat-latin/description/
/// </summary>
public interface IGoatLatin
{
    /// <summary>
    ///     Converts <paramref name="sentence" /> to Goat Latin by appending "ma" to vowel-starting words, moving the first
    ///     letter of consonant-starting words to the end before appending "ma", and adding one letter 'a' per word index.
    /// </summary>
    /// <param name="sentence">The sentence of words separated by single spaces.</param>
    /// <returns>The sentence converted to Goat Latin.</returns>
    string ToGoatLatin(string sentence);
}