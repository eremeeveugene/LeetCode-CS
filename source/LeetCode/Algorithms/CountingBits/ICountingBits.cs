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

namespace LeetCode.Algorithms.CountingBits;

/// <summary>
///     https://leetcode.com/problems/counting-bits/description/
/// </summary>
public interface ICountingBits
{
    /// <summary>
    ///     Computes, for every integer i in the range from 0 to <paramref name="n" />, the number of 1 bits in the binary
    ///     representation of i.
    /// </summary>
    /// <param name="n">The upper bound of the range.</param>
    /// <returns>An array of length <paramref name="n" /> + 1 where the element at index i is the number of 1 bits in i.</returns>
    int[] CountBits(int n);
}