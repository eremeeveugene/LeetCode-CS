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

namespace LeetCode.Algorithms.PartitionEqualSubsetSum;

/// <inheritdoc />
public sealed class PartitionEqualSubsetSumDynamicProgramming : IPartitionEqualSubsetSum
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * target)
    ///     Space complexity - O(n)
    /// </remarks>
    public bool CanPartition(int[] nums)
    {
        var total = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            total += nums[i];
        }

        if (total % 2 != 0)
        {
            return false;
        }

        var target = total / 2;

        var dp = new bool[target + 1];

        dp[0] = true;

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            for (var j = target; j >= num; j--)
            {
                dp[j] = dp[j] || dp[j - num];
            }
        }

        return dp[^1];
    }
}