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

namespace LeetCode.Algorithms.KeyboardRow;

/// <summary>
///     https://leetcode.com/problems/keyboard-row/description/
/// </summary>
public interface IKeyboardRow
{
    /// <summary>
    ///     Finds the words in <paramref name="words" /> that can be typed using letters of only one row of an American
    ///     keyboard.
    /// </summary>
    /// <param name="words">The array of words to check.</param>
    /// <returns>An array of the words that can be typed using letters of only one keyboard row.</returns>
    string[] FindWords(string[] words);
}