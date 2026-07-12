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

namespace LeetCode.Algorithms.FindTheLongestSubstringContainingVowelsInEvenCounts;

/// <summary>
///     https://leetcode.com/problems/find-the-longest-substring-containing-vowels-in-even-counts/
/// </summary>
public interface IFindTheLongestSubstringContainingVowelsInEvenCounts
{
    /// <summary>
    ///     Finds the size of the longest substring of <paramref name="s" /> in which each vowel appears an even number of
    ///     times.
    /// </summary>
    /// <param name="s">The string to search.</param>
    /// <returns>The length of the longest substring containing each vowel an even number of times.</returns>
    int FindTheLongestSubstring(string s);
}