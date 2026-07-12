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

namespace LeetCode.Algorithms.BitwiseXOROfAllPairings;

/// <summary>
///     https://leetcode.com/problems/bitwise-xor-of-all-pairings/description/
/// </summary>
public interface IBitwiseXOROfAllPairings
{
    /// <summary>
    ///     Computes the bitwise XOR of all pairings between <paramref name="nums1" /> and <paramref name="nums2" />, where
    ///     each element of one array is XORed with every element of the other.
    /// </summary>
    /// <param name="nums1">The first array of integers.</param>
    /// <param name="nums2">The second array of integers.</param>
    /// <returns>The bitwise XOR of all pairing results.</returns>
    int XorAllNums(int[] nums1, int[] nums2);
}