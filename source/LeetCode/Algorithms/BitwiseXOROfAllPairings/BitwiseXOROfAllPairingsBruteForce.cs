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

/// <inheritdoc />
public sealed class BitwiseXOROfAllPairingsBruteForce : IBitwiseXOROfAllPairings
{
    /// <summary>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="nums2"></param>
    /// <returns></returns>
    public int XorAllNums(int[] nums1, int[] nums2)
    {
        var result = 0;

        foreach (var num1 in nums1)
        {
            foreach (var num2 in nums2)
            {
                result ^= num1 ^ num2;
            }
        }

        return result;
    }
}