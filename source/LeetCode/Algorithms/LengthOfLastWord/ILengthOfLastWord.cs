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

namespace LeetCode.Algorithms.LengthOfLastWord;

/// <summary>
///     https://leetcode.com/problems/length-of-last-word/description/
/// </summary>
public interface ILengthOfLastWord
{
    /// <summary>
    ///     Finds the length of the last word in <paramref name="s" />, where a word is a maximal substring of non-space characters.
    /// </summary>
    /// <param name="s">The string to examine.</param>
    /// <returns>The length of the last word in <paramref name="s" />.</returns>
    int LengthOfLastWord(string s);
}