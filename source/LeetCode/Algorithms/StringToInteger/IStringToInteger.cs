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

namespace LeetCode.Algorithms.StringToInteger;

/// <summary>
///     https://leetcode.com/problems/string-to-integer-atoi/description/
/// </summary>
public interface IStringToInteger
{
    /// <summary>
    ///     Converts <paramref name="s" /> to a 32-bit signed integer following the same rules as the C
    ///     atoi function, including skipping leading whitespace, reading an optional sign, and clamping to the
    ///     32-bit signed integer range.
    /// </summary>
    /// <param name="s">The string to convert to an integer.</param>
    /// <returns>The parsed 32-bit signed integer, clamped to the valid range.</returns>
    int MyAtoi(string s);
}