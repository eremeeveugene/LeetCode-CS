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

namespace LeetCode.Algorithms.BinaryNumberWithAlternatingBits;

/// <summary>
///     https://leetcode.com/problems/binary-number-with-alternating-bits/description/
/// </summary>
public interface IBinaryNumberWithAlternatingBits
{
    /// <summary>
    ///     Determines whether the binary representation of <paramref name="n" /> has alternating bits, i.e. every two
    ///     adjacent bits differ.
    /// </summary>
    /// <param name="n">The positive integer to check.</param>
    /// <returns><c>true</c> if the binary representation of <paramref name="n" /> has alternating bits; otherwise, <c>false</c>.</returns>
    bool HasAlternatingBits(int n);
}