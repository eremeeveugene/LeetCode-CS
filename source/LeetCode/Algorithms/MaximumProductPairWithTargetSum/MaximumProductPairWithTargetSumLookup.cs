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
public sealed class MaximumProductPairWithTargetSumLookup : IMaximumProductPairWithTargetSum
{
    private const int MinValue = -100;
    private const int MaxValue = 100;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + R), where R = MaxValue - MinValue + 1
    ///     Space complexity - O(R), where R = MaxValue - MinValue + 1
    /// </remarks>
    public int[] MaxProductPair(int[] nums, int target)
    {
        var n = nums.Length;

        Span<int> indicesLookup = stackalloc int[MaxValue - MinValue + 1];

        indicesLookup.Fill(-1);

        var maxProduct = int.MinValue;

        int[] result = [-1, -1];

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];
            var complement = target - num;

            if (complement != num && complement is >= MinValue and <= MaxValue)
            {
                var complementIndex = indicesLookup[complement - MinValue];
                var product = num * complement;

                if (complementIndex != -1 && product > maxProduct)
                {
                    maxProduct = product;

                    result[0] = num > complement ? i : complementIndex;
                    result[1] = num > complement ? complementIndex : i;
                }
            }

            if (indicesLookup[num - MinValue] == -1)
            {
                indicesLookup[num - MinValue] = i;
            }
        }

        return result;
    }
}