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

namespace LeetCode.Algorithms.RotateFunction;

/// <inheritdoc />
public sealed class RotateFunctionDynamicProgramming : IRotateFunction
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaxRotateFunction(int[] nums)
    {
        var n = nums.Length;

        var sum = 0;
        var value = 0;

        for (var i = 0; i < n; i++)
        {
            sum += nums[i];
            value += nums[i] * i;
        }

        var maxValue = value;

        for (var i = n - 1; i > 0; i--)
        {
            value += sum - (n * nums[i]);

            maxValue = Math.Max(maxValue, value);
        }

        return maxValue;
    }
}