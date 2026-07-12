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

namespace LeetCode.Algorithms.MinimizeXOR;

/// <summary>
///     https://leetcode.com/problems/minimize-xor/description/
/// </summary>
public interface IMinimizeXOR
{
    /// <summary>
    ///     Finds a positive integer with the same number of set bits as <paramref name="num2" /> that minimizes the
    ///     XOR with <paramref name="num1" />.
    /// </summary>
    /// <param name="num1">The integer to minimize the XOR against.</param>
    /// <param name="num2">The integer whose set-bit count must be matched.</param>
    /// <returns>The integer that minimizes the XOR with <paramref name="num1" /> while matching the set-bit count of <paramref name="num2" />.</returns>
    int MinimizeXor(int num1, int num2);
}