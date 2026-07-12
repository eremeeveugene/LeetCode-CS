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

namespace LeetCode.Algorithms.ReverseString2;

/// <summary>
///     https://leetcode.com/problems/reverse-string-ii/
/// </summary>
public interface IReverseString2
{
    /// <summary>
    ///     Reverses the first <paramref name="k" /> characters of every consecutive block of 2 * <paramref name="k" />
    ///     characters in <paramref name="s" />, counting from the start of the string.
    /// </summary>
    /// <param name="s">The string to process.</param>
    /// <param name="k">The number of characters to reverse in each block.</param>
    /// <returns>The resulting string after the block-wise reversal.</returns>
    string ReverseStr(string s, int k);
}