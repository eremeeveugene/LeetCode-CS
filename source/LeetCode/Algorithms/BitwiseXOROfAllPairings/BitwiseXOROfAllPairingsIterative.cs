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
public sealed class BitwiseXOROfAllPairingsIterative : IBitwiseXOROfAllPairings
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(1)
    /// </remarks>
    public int XorAllNums(int[] nums1, int[] nums2)
    {
        var n = nums1.Length;
        var m = nums2.Length;

        var result = 0;

        if (m % 2 == 1)
        {
            for (var i = 0; i < n; i++)
            {
                var num1 = nums1[i];

                result ^= num1;
            }
        }

        if (n % 2 == 1)
        {
            for (var i = 0; i < m; i++)
            {
                var num2 = nums2[i];

                result ^= num2;
            }
        }

        return result;
    }
}