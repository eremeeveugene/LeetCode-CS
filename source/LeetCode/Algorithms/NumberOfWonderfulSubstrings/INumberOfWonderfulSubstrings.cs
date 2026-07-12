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

namespace LeetCode.Algorithms.NumberOfWonderfulSubstrings;

/// <summary>
///     https://leetcode.com/problems/number-of-wonderful-substrings/description/
/// </summary>
public interface INumberOfWonderfulSubstrings
{
    /// <summary>
    ///     Counts the number of wonderful substrings of <paramref name="word" />, where a substring is wonderful if
    ///     at most one of its characters appears an odd number of times.
    /// </summary>
    /// <param name="word">The string consisting of the first ten lowercase English letters ('a' through 'j').</param>
    /// <returns>The number of wonderful substrings of <paramref name="word" />.</returns>
    long WonderfulSubstrings(string word);
}