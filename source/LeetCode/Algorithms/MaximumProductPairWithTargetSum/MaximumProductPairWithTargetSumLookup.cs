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
            var complementIndex = GetIndex(indicesLookup, complement);

            if (indicesLookup[num - MinValue] == -1)
            {
                indicesLookup[num - MinValue] = i;
            }

            if (complement == num || complementIndex == -1)
            {
                continue;
            }

            var product = num * complement;

            if (product <= maxProduct)
            {
                continue;
            }

            maxProduct = product;

            var isLarger = num > complement;

            result[0] = isLarger ? i : complementIndex;
            result[1] = isLarger ? complementIndex : i;
        }

        return result;
    }

    private static int GetIndex(ReadOnlySpan<int> indicesLookup, int value)
    {
        if (value is < MinValue or > MaxValue)
        {
            return -1;
        }

        return indicesLookup[value - MinValue];
    }
}