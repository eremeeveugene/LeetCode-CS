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
public sealed class PredictTheWinnerDynamicProgramming : IPredictTheWinner
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n^2)
    /// </remarks>
    public bool PredictTheWinner(int[] nums)
    {
        var n = nums.Length;

        var scoreDifference = new int[n, n];

        for (var i = 0; i < n; i++)
        {
            scoreDifference[i, i] = nums[i];
        }

        for (var length = 2; length <= n; length++)
        {
            for (var i = 0; i <= n - length; i++)
            {
                var j = i + length - 1;

                scoreDifference[i, j] = Math.Max(nums[i] - scoreDifference[i + 1, j], nums[j] - scoreDifference[i, j - 1]);
            }
        }

        return scoreDifference[0, n - 1] >= 0;
    }
}