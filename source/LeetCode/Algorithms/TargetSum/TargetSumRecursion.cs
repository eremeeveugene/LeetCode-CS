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

namespace LeetCode.Algorithms.TargetSum;

/// <inheritdoc />
public sealed class TargetSumRecursion : ITargetSum
{
    /// <summary>
    ///     Time complexity - O(n * totalSum)
    ///     Space complexity - O(n * totalSum)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int FindTargetSumWays(int[] nums, int target)
    {
        var totalSum = nums.Sum();

        return CalculateWays(
            nums,
            0,
            0,
            target,
            totalSum,
            InitializeMemo(nums.Length, (2 * totalSum) + 1)
        );
    }

    private static int[,] InitializeMemo(int rows, int cols)
    {
        var memo = new int[rows, cols];

        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                memo[i, j] = int.MinValue;
            }
        }

        return memo;
    }

    private static int CalculateWays(int[] nums, int currentIndex, int currentSum, int target, int totalSum,
        int[,] memo)
    {
        if (currentIndex == nums.Length)
        {
            return currentSum == target ? 1 : 0;
        }

        if (memo[currentIndex, currentSum + totalSum] != int.MinValue)
        {
            return memo[currentIndex, currentSum + totalSum];
        }

        memo[currentIndex, currentSum + totalSum] =
            CalculateWays(nums, currentIndex + 1, currentSum + nums[currentIndex], target, totalSum, memo) +
            CalculateWays(nums, currentIndex + 1, currentSum - nums[currentIndex], target, totalSum, memo);

        return memo[currentIndex, currentSum + totalSum];
    }
}