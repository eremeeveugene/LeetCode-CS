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

namespace LeetCode.Algorithms.ReverseStringPrefix;

/// <summary>
///     https://leetcode.com/problems/reverse-string-prefix/description/
/// </summary>
public interface IReverseStringPrefix
{
    /// <summary>
    ///     Reverses the first <paramref name="k" /> characters of <paramref name="s" />, leaving the remainder of the
    ///     string unchanged.
    /// </summary>
    /// <param name="s">The string whose prefix is reversed.</param>
    /// <param name="k">The number of leading characters to reverse.</param>
    /// <returns>The resulting string after reversing the first <paramref name="k" /> characters.</returns>
    string ReversePrefix(string s, int k);
}