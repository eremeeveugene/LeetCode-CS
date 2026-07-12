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

namespace LeetCode.Algorithms.SortVowelsInString;

/// <summary>
///     https://leetcode.com/problems/sort-vowels-in-a-string/description/
/// </summary>
public interface ISortVowelsInString
{
    /// <summary>
    ///     Rearranges the vowels of <paramref name="s" /> in non-decreasing order of their ASCII values while
    ///     keeping all consonants in their original positions.
    /// </summary>
    /// <param name="s">The string whose vowels are to be sorted.</param>
    /// <returns>The string <paramref name="s" /> with its vowels sorted in place.</returns>
    string SortVowels(string s);
}