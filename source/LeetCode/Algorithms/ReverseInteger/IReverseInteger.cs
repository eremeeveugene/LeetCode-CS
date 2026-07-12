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

namespace LeetCode.Algorithms.ReverseInteger;

/// <summary>
///     https://leetcode.com/problems/reverse-integer/description/
/// </summary>
public interface IReverseInteger
{
    /// <summary>
    ///     Reverses the digits of the signed 32-bit integer <paramref name="x" />.
    /// </summary>
    /// <param name="x">The signed 32-bit integer whose digits are reversed.</param>
    /// <returns>The reversed integer, or 0 if reversing <paramref name="x" /> causes a 32-bit overflow.</returns>
    int Reverse(int x);
}