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

namespace LeetCode.Algorithms.LongestSubstringWithoutRepeatingCharacters;

/// <summary>
///     https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
/// </summary>
public interface ILongestSubstringWithoutRepeatingCharacters
{
    /// <summary>
    ///     Finds the length of the longest substring of <paramref name="s" /> without repeating characters.
    /// </summary>
    /// <param name="s">The string to search for the longest substring without repeating characters.</param>
    /// <returns>The length of the longest substring of <paramref name="s" /> with no repeated characters.</returns>
    int LengthOfLongestSubstring(string s);
}