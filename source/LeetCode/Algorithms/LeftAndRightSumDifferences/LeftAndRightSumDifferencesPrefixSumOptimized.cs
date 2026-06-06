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

namespace LeetCode.Algorithms.LeftAndRightSumDifferences;

/// <inheritdoc />
public sealed class LeftAndRightSumDifferencesPrefixSumOptimized : ILeftAndRightSumDifferences
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] LeftRightDifference(int[] nums)
    {
        var n = nums.Length;

        Span<int> leftSum = stackalloc int[n];

        for (var i = 0; i < n - 1; i++)
        {
            leftSum[i + 1] = leftSum[i] + nums[i];
        }

        var rightSum = 0;

        var result = new int[n];

        for (var i = n - 1; i >= 0; i--)
        {
            result[i] = Math.Abs(leftSum[i] - rightSum);

            rightSum += nums[i];
        }

        return result;
    }
}