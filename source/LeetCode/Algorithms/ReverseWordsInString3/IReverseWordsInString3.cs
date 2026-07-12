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

namespace LeetCode.Algorithms.ReverseWordsInString3;

/// <summary>
///     https://leetcode.com/problems/reverse-words-in-a-string-iii/description/
/// </summary>
public interface IReverseWordsInString3
{
    /// <summary>
    ///     Reverses the characters of each word in <paramref name="s" /> while preserving whitespace and the original
    ///     word order.
    /// </summary>
    /// <param name="s">The string whose words are reversed in place.</param>
    /// <returns>The resulting string with each word's characters reversed.</returns>
    string ReverseWords(string s);
}