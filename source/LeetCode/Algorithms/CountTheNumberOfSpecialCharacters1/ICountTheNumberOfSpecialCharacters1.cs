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

namespace LeetCode.Algorithms.CountTheNumberOfSpecialCharacters1;

/// <summary>
///     https://leetcode.com/problems/count-the-number-of-special-characters-i/description/
/// </summary>
public interface ICountTheNumberOfSpecialCharacters1
{
    /// <summary>
    ///     Counts the number of letters that appear in both lowercase and uppercase in the given word.
    /// </summary>
    /// <param name="word">A string consisting of lowercase and uppercase English letters.</param>
    /// <returns>The number of special characters in <paramref name="word" />.</returns>
    int NumberOfSpecialChars(string word);
}