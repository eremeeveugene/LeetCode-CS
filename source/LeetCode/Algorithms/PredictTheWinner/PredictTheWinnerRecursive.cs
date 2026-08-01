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

namespace LeetCode.Algorithms.PredictTheWinner;

/// <inheritdoc />
public sealed class PredictTheWinnerRecursive : IPredictTheWinner
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n^2)
    /// </remarks>
    public bool PredictTheWinner(int[] nums)
    {
        var n = nums.Length;

        var memo = InitializeMemo(n);

        var scoreDifference = CalculateScoreDifference(nums, 0, n - 1, memo);

        return scoreDifference >= 0;
    }

    private static int[,] InitializeMemo(int n)
    {
        var memo = new int[n, n];

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                memo[i, j] = int.MinValue;
            }
        }

        return memo;
    }

    private static int CalculateScoreDifference(int[] nums, int left, int right, int[,] memo)
    {
        if (left == right)
        {
            return nums[left];
        }

        if (memo[left, right] != int.MinValue)
        {
            return memo[left, right];
        }

        var pickLeft = nums[left] - CalculateScoreDifference(nums, left + 1, right, memo);

        var pickRight = nums[right] - CalculateScoreDifference(nums, left, right - 1, memo);

        memo[left, right] = Math.Max(pickLeft, pickRight);

        return memo[left, right];
    }
}