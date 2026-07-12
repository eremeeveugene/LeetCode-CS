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

namespace LeetCode.Algorithms.ComplementOfBase10Integer;

/// <summary>
///     https://leetcode.com/problems/complement-of-base-10-integer/
/// </summary>
public interface IComplementOfBase10Integer
{
    /// <summary>
    ///     Computes the complement of <paramref name="n" /> by flipping every bit in its binary representation.
    /// </summary>
    /// <param name="n">The base-10 integer to complement.</param>
    /// <returns>The complement of <paramref name="n" />.</returns>
    int BitwiseComplement(int n);
}