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

namespace LeetCode.Algorithms.ReorderedPowerOfTwo;

/// <summary>
///     https://leetcode.com/problems/reordered-power-of-2/description/
/// </summary>
public interface IReorderedPowerOfTwo
{
    /// <summary>
    ///     Determines whether the digits of <paramref name="n" /> can be rearranged, without leading zeros, to form a
    ///     power of two.
    /// </summary>
    /// <param name="n">The positive integer whose digits are considered.</param>
    /// <returns><see langword="true" /> if some rearrangement of the digits of <paramref name="n" /> is a power of two; otherwise, <see langword="false" />.</returns>
    bool ReorderedPowerOf2(int n);
}