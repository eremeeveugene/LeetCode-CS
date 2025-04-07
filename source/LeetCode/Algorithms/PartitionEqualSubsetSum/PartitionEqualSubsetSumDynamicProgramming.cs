// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class PartitionEqualSubsetSumDynamicProgramming : IPartitionEqualSubsetSum
{
    /// <summary>
    ///     Time complexity - O(n * target)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public bool CanPartition(int[] nums)
    {
        var total = nums.Sum();

        if (total % 2 != 0)
        {
            return false;
        }

        var target = total / 2;

        var dp = new bool[target + 1];

        dp[0] = true;

        foreach (var num in nums)
        {
            for (var i = target; i >= num; i--)
            {
                dp[i] = dp[i] || dp[i - num];
            }
        }

        return dp[target];
    }
}