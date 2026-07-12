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

namespace LeetCode.Algorithms.NumberOfOneBits;

/// <summary>
///     https://leetcode.com/problems/number-of-1-bits/
/// </summary>
public interface INumberOfOneBits
{
    /// <summary>
    ///     Counts the number of set bits (the Hamming weight) in the binary representation of <paramref name="n" />.
    /// </summary>
    /// <param name="n">The integer whose set bits should be counted.</param>
    /// <returns>The number of '1' bits in the binary representation of <paramref name="n" />.</returns>
    int HammingWeight(int n);
}