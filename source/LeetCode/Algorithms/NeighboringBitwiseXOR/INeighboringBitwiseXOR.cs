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

namespace LeetCode.Algorithms.NeighboringBitwiseXOR;

/// <summary>
///     https://leetcode.com/problems/neighboring-bitwise-xor/description/
/// </summary>
public interface INeighboringBitwiseXOR
{
    /// <summary>
    ///     Determines whether there exists a valid binary array whose neighboring-element XORs (with the last
    ///     element paired with the first) produce the given <paramref name="derived" /> array.
    /// </summary>
    /// <param name="derived">The array formed by XOR-ing each adjacent pair of elements of the hypothetical original binary array.</param>
    /// <returns><see langword="true" /> if a valid original binary array exists; otherwise, <see langword="false" />.</returns>
    bool DoesValidArrayExist(int[] derived);
}