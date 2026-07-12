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

namespace LeetCode.Algorithms.FindWordsContainingCharacter;

/// <summary>
///     https://leetcode.com/problems/find-words-containing-character/
/// </summary>
public interface IFindWordsContainingCharacter
{
    /// <summary>
    ///     Finds the indices of the words in <paramref name="words" /> that contain the character <paramref name="x" />.
    /// </summary>
    /// <param name="words">The array of words to search.</param>
    /// <param name="x">The character to look for.</param>
    /// <returns>The indices of the words containing <paramref name="x" />, in any order.</returns>
    IList<int> FindWordsContaining(string[] words, char x);
}