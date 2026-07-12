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

namespace LeetCode.Algorithms.UniqueMorseCodeWords;

/// <summary>
///     https://leetcode.com/problems/unique-morse-code-words/description/
/// </summary>
public interface IUniqueMorseCodeWords
{
    /// <summary>
    ///     Counts the number of distinct Morse code transformations produced by translating each word in
    ///     <paramref name="words" /> letter by letter.
    /// </summary>
    /// <param name="words">The array of lowercase words to translate into Morse code.</param>
    /// <returns>The number of distinct Morse code representations among the words.</returns>
    int UniqueMorseRepresentations(string[] words);
}