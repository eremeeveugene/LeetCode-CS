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

namespace LeetCode.Algorithms.ReversePrefixOfWord;

/// <summary>
///     https://leetcode.com/problems/reverse-prefix-of-word/description/
/// </summary>
public interface IReversePrefixOfWord
{
    /// <summary>
    ///     Reverses the prefix of <paramref name="word" /> up to and including the first occurrence of
    ///     <paramref name="ch" />.
    /// </summary>
    /// <param name="word">The string whose prefix is reversed.</param>
    /// <param name="ch">The character marking the end of the prefix to reverse.</param>
    /// <returns>The resulting string after reversing the prefix, or the original string if <paramref name="ch" /> is not found.</returns>
    string ReversePrefix(string word, char ch);
}