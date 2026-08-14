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

namespace LeetCode.Algorithms.MaximumLengthSubstringWithTwoOccurrences;

/// <summary>
///     https://leetcode.com/problems/maximum-length-substring-with-two-occurrences/description/
/// </summary>
public interface IMaximumLengthSubstringWithTwoOccurrences
{
    /// <summary>
    ///     Determines the length of the longest substring of <paramref name="s" /> in which every character
    ///     appears at most twice.
    /// </summary>
    /// <param name="s">The string to search.</param>
    /// <returns>The maximum length of a qualifying substring.</returns>
    int MaximumLengthSubstring(string s);
}