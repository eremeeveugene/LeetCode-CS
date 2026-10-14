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
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(1)
    /// </remarks>
    public int XorAllNums(int[] nums1, int[] nums2)
    {
        var n = nums1.Length;
        var m = nums2.Length;

        var result = 0;

        for (var i = 0; i < n; i++)
        {
            var num1 = nums1[i];

            for (var j = 0; j < m; j++)
            {
                var num2 = nums2[j];

                result ^= num1 ^ num2;
            }
        }

        return result;
    }
}