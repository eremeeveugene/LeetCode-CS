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

namespace LeetCode.Algorithms.ValidWord;

/// <summary>
///     https://leetcode.com/problems/valid-word/description/
/// </summary>
public interface IValidWord
{
    /// <summary>
    ///     Determines whether <paramref name="word" /> is valid — at least 3 characters long, consisting only of
    ///     digits and English letters, and containing at least one vowel and one consonant.
    /// </summary>
    /// <param name="word">The string to validate.</param>
    /// <returns><see langword="true" /> if <paramref name="word" /> is valid; otherwise, <see langword="false" />.</returns>
    bool IsValid(string word);
}