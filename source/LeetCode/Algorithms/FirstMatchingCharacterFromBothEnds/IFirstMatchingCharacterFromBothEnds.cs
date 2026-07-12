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

namespace LeetCode.Algorithms.FirstMatchingCharacterFromBothEnds;

/// <summary>
///     https://leetcode.com/problems/first-matching-character-from-both-ends/description/
/// </summary>
public interface IFirstMatchingCharacterFromBothEnds
{
    /// <summary>
    ///     Finds the smallest index of a character in <paramref name="s" /> that also appears elsewhere in the string when
    ///     scanning from both ends.
    /// </summary>
    /// <param name="s">The string to search.</param>
    /// <returns>The smallest index of the first matching character, or -1 if no such character exists.</returns>
    int FirstMatchingIndex(string s);
}