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

namespace LeetCode.Algorithms.ReverseBits;

/// <summary>
///     https://leetcode.com/problems/reverse-bits/description/
/// </summary>
public interface IReverseBits
{
    /// <summary>
    ///     Reverses the bits of the 32-bit integer <paramref name="n" />.
    /// </summary>
    /// <param name="n">The 32-bit integer whose bits are reversed.</param>
    /// <returns>The integer obtained by reversing the bits of <paramref name="n" />.</returns>
    int ReverseBits(int n);
}