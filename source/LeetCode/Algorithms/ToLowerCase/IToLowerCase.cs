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

namespace LeetCode.Algorithms.ToLowerCase;

/// <summary>
///     https://leetcode.com/problems/to-lower-case/
/// </summary>
public interface IToLowerCase
{
    /// <summary>
    ///     Converts every uppercase letter in <paramref name="s" /> to its lowercase equivalent.
    /// </summary>
    /// <param name="s">The string to convert.</param>
    /// <returns>The lowercase version of <paramref name="s" />.</returns>
    string ToLowerCase(string s);
}