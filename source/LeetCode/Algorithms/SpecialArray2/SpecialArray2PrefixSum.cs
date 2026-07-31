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

namespace LeetCode.Algorithms.SpecialArray2;

/// <inheritdoc />
public sealed class SpecialArray2PrefixSum : ISpecialArray2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m + n)
    ///     Space complexity - O(m)
    /// </remarks>
    public bool[] IsArraySpecial(int[] nums, int[][] queries)
    {
        var sameParity = new int[nums.Length - 1];

        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] % 2 == nums[i + 1] % 2)
            {
                sameParity[i] = 1;
            }
            else
            {
                sameParity[i] = 0;
            }
        }

        var prefixSum = new int[nums.Length];

        for (var i = 1; i < nums.Length; i++)
        {
            prefixSum[i] = prefixSum[i - 1] + sameParity[i - 1];
        }

        var result = new bool[queries.Length];

        for (var i = 0; i < queries.Length; i++)
        {
            var start = queries[i][0];
            var end = queries[i][1];

            var numBadPairs = prefixSum[end] - prefixSum[start];

            result[i] = numBadPairs == 0;
        }

        return result;
    }
}