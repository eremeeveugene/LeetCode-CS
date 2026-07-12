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

namespace LeetCode.Algorithms.FindCommonCharacters;

/// <summary>
///     https://leetcode.com/problems/find-common-characters/
/// </summary>
public interface IFindCommonCharacters
{
    /// <summary>
    ///     Finds all characters that appear in every string of <paramref name="words" />, including duplicates.
    /// </summary>
    /// <param name="words">The array of lowercase words to intersect.</param>
    /// <returns>A list of characters, with duplicates, common to all strings in <paramref name="words" />.</returns>
    IList<string> CommonChars(string[] words);
}