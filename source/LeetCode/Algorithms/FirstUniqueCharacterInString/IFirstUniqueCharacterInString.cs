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

namespace LeetCode.Algorithms.FirstUniqueCharacterInString;

/// <summary>
///     https://leetcode.com/problems/first-unique-character-in-a-string/description/
/// </summary>
public interface IFirstUniqueCharacterInString
{
    /// <summary>
    ///     Finds the index of the first non-repeating character in <paramref name="s" />.
    /// </summary>
    /// <param name="s">The string to search.</param>
    /// <returns>The index of the first non-repeating character, or -1 if every character repeats.</returns>
    int FirstUniqChar(string s);
}