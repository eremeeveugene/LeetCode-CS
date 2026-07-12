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

namespace LeetCode.Algorithms.LargestSubstringBetweenTwoEqualCharacters;

/// <summary>
///     https://leetcode.com/problems/largest-substring-between-two-equal-characters/description/
/// </summary>
public interface ILargestSubstringBetweenTwoEqualCharacters
{
    /// <summary>
    ///     Finds the length of the longest substring of <paramref name="s" /> between two equal characters, excluding the
    ///     two characters.
    /// </summary>
    /// <param name="s">The string to search.</param>
    /// <returns>The length of the longest substring between two equal characters, or -1 if no such substring exists.</returns>
    int MaxLengthBetweenEqualCharacters(string s);
}