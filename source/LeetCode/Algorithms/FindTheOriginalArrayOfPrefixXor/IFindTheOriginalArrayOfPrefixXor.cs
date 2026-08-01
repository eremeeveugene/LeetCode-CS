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

namespace LeetCode.Algorithms.FindTheOriginalArrayOfPrefixXor;

/// <summary>
///     https://leetcode.com/problems/find-the-original-array-of-prefix-xor/
/// </summary>
public interface IFindTheOriginalArrayOfPrefixXor
{
    /// <summary>
    ///     Reconstructs the original array from its prefix XOR array <paramref name="pref" />, where each prefix element is the XOR of all original elements
    ///     up to that index.
    /// </summary>
    /// <param name="pref">The prefix XOR array to reconstruct the original array from.</param>
    /// <returns>The reconstructed original array.</returns>
    int[] FindArray(int[] pref);
}