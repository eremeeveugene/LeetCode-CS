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

namespace LeetCode.Algorithms.MaximumProductPairWithTargetSum;

/// <inheritdoc />
public sealed class MaximumProductPairWithTargetSumBruteForce : IMaximumProductPairWithTargetSum
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    public int[] MaxProductPair(int[] nums, int target)
    {
        var n = nums.Length;

        var maxProduct = int.MinValue;

        int[] result = [-1, -1];

        for (var i = 0; i < n; i++)
        {
            var larger = nums[i];

            for (var j = 0; j < n; j++)
            {
                var smaller = nums[j];

                if (larger <= smaller || larger + smaller != target)
                {
                    continue;
                }

                var product = larger * smaller;

                if (product <= maxProduct)
                {
                    continue;
                }

                maxProduct = product;

                result[0] = i;
                result[1] = j;
            }
        }

        return result;
    }
}