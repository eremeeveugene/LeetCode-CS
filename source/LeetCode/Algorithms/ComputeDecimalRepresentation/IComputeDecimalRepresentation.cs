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

namespace LeetCode.Algorithms.ComputeDecimalRepresentation;

/// <summary>
///     https://leetcode.com/problems/compute-decimal-representation/description/
/// </summary>
public interface IComputeDecimalRepresentation
{
    /// <summary>
    ///     Decomposes <paramref name="n" /> into the sum of base-10 components, where each component is a non-zero digit
    ///     multiplied by its place value, ordered from largest to smallest.
    /// </summary>
    /// <param name="n">The positive integer to decompose.</param>
    /// <returns>The base-10 components of <paramref name="n" /> in descending order.</returns>
    int[] DecimalRepresentation(int n);
}