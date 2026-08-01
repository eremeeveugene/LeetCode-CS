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
    ///     Space complexity - O(n)
    /// </remarks>
    public bool PredictTheWinner(int[] nums)
    {
        var n = nums.Length;

        Span<int> scoreDifference = stackalloc int[n];

        for (var j = 0; j < n; j++)
        {
            var rightNum = nums[j];

            scoreDifference[j] = rightNum;

            for (var i = j - 1; i >= 0; i--)
            {
                var leftNum = nums[i];

                var pickLeft = leftNum - scoreDifference[i + 1];
                var pickRight = rightNum - scoreDifference[i];

                scoreDifference[i] = Math.Max(pickLeft, pickRight);
            }
        }

        return scoreDifference[0] >= 0;
    }
}