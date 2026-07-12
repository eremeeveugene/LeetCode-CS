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

namespace LeetCode.Algorithms.XOROperationInAnArray;

/// <summary>
///     https://leetcode.com/problems/xor-operation-in-an-array/
/// </summary>
public interface IXOROperationInAnArray
{
    /// <summary>
    ///     Computes the bitwise XOR of the array formed by <c>nums[i] = start + 2 * i</c> for
    ///     <c>i</c> from 0 to <paramref name="n" /> - 1.
    /// </summary>
    /// <param name="n">The number of elements in the generated array.</param>
    /// <param name="start">The starting value used to generate the array.</param>
    /// <returns>The bitwise XOR of all elements in the generated array.</returns>
    int XorOperation(int n, int start);
}