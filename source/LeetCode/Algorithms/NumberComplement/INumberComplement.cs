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

namespace LeetCode.Algorithms.NumberComplement;

/// <summary>
///     https://leetcode.com/problems/number-complement/
/// </summary>
public interface INumberComplement
{
    /// <summary>
    ///     Computes the complement of <paramref name="num" /> by flipping all the bits in its binary representation,
    ///     excluding any leading zero bits.
    /// </summary>
    /// <param name="num">The positive integer whose complement should be computed.</param>
    /// <returns>The complement of <paramref name="num" />.</returns>
    int FindComplement(int num);
}