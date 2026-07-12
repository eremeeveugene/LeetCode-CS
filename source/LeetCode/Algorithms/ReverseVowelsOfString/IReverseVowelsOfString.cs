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

namespace LeetCode.Algorithms.ReverseVowelsOfString;

/// <summary>
///     https://leetcode.com/problems/reverse-vowels-of-a-string/
/// </summary>
public interface IReverseVowelsOfString
{
    /// <summary>
    ///     Reverses only the vowels within <paramref name="s" />, leaving all other characters in their original
    ///     positions.
    /// </summary>
    /// <param name="s">The string whose vowels are reversed.</param>
    /// <returns>The resulting string with the vowels reversed.</returns>
    string ReverseVowels(string s);
}