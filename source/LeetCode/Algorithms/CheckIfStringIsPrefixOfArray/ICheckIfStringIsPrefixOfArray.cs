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

namespace LeetCode.Algorithms.CheckIfStringIsPrefixOfArray;

/// <summary>
///     https://leetcode.com/problems/check-if-string-is-a-prefix-of-array/description/
/// </summary>
public interface ICheckIfStringIsPrefixOfArray
{
    /// <summary>
    ///     Determines whether <paramref name="s" /> can be formed by concatenating the first k strings of
    ///     <paramref name="words" /> for some positive k.
    /// </summary>
    /// <param name="s">The string to check.</param>
    /// <param name="words">The array of words.</param>
    /// <returns><c>true</c> if <paramref name="s" /> is a prefix string of <paramref name="words" />; otherwise, <c>false</c>.</returns>
    bool IsPrefixString(string s, string[] words);
}