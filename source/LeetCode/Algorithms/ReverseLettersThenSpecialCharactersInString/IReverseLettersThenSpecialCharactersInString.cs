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

namespace LeetCode.Algorithms.ReverseLettersThenSpecialCharactersInString;

/// <summary>
///     https://leetcode.com/problems/reverse-letters-then-special-characters-in-a-string/description/
/// </summary>
public interface IReverseLettersThenSpecialCharactersInString
{
    /// <summary>
    ///     Reverses the order of the letters in <paramref name="s" /> while keeping every non-letter character fixed in
    ///     its original position.
    /// </summary>
    /// <param name="s">The string containing letters and special characters to process.</param>
    /// <returns>The resulting string with letters reversed and special characters left in place.</returns>
    string ReverseByType(string s);
}