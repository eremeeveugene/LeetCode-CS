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

namespace LeetCode.Algorithms.CountTheNumberOfConsistentStrings;

/// <summary>
///     https://leetcode.com/problems/count-the-number-of-consistent-strings/
/// </summary>
public interface ICountTheNumberOfConsistentStrings
{
    /// <summary>
    ///     Counts the strings in <paramref name="words" /> that consist only of characters found in
    ///     <paramref name="allowed" />.
    /// </summary>
    /// <param name="allowed">The string of distinct characters permitted in a consistent word.</param>
    /// <param name="words">The array of words to check for consistency.</param>
    /// <returns>The number of consistent strings in <paramref name="words" />.</returns>
    int CountConsistentStrings(string allowed, string[] words);
}