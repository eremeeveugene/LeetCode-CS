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

namespace LeetCode.Algorithms.MinimumNumberOfPushesToTypeWord2;

/// <summary>
///     https://leetcode.com/problems/minimum-number-of-pushes-to-type-word-ii/description/
/// </summary>
public interface IMinimumNumberOfPushesToTypeWord2
{
    /// <summary>
    ///     Determines the minimum number of key pushes required to type <paramref name="word" />, which consists of
    ///     lowercase English letters that may repeat, on an 8-key keypad, given an optimal mapping of letters to keys.
    /// </summary>
    /// <param name="word">The string of lowercase English letters to type.</param>
    /// <returns>The minimum number of pushes needed to type <paramref name="word" />.</returns>
    int MinimumPushes(string word);
}