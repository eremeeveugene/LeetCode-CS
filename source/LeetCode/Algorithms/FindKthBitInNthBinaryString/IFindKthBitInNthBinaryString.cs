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

namespace LeetCode.Algorithms.FindKthBitInNthBinaryString;

/// <summary>
///     https://leetcode.com/problems/find-kth-bit-in-nth-binary-string/description/
/// </summary>
public interface IFindKthBitInNthBinaryString
{
    /// <summary>
    ///     Finds the <paramref name="k" />-th bit of the <paramref name="n" />-th binary string built by the rule
    ///     S(n) = S(n - 1) + "1" + reverse(invert(S(n - 1))).
    /// </summary>
    /// <param name="n">The index of the binary string in the sequence.</param>
    /// <param name="k">The one-based position of the bit to find.</param>
    /// <returns>The <paramref name="k" />-th bit of the <paramref name="n" />-th binary string.</returns>
    char FindKthBit(int n, int k);
}