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

namespace LeetCode.Algorithms.MinimumBitFlipsToConvertNumber;

/// <summary>
///     https://leetcode.com/problems/minimum-bit-flips-to-convert-number/description/
/// </summary>
public interface IMinimumBitFlipsToConvertNumber
{
    /// <summary>
    ///     Finds the minimum number of bit flips required to convert <paramref name="start" /> into
    ///     <paramref name="goal" />.
    /// </summary>
    /// <param name="start">The starting integer.</param>
    /// <param name="goal">The target integer.</param>
    /// <returns>The minimum number of bit flips needed to convert <paramref name="start" /> to <paramref name="goal" />.</returns>
    int MinBitFlips(int start, int goal);
}