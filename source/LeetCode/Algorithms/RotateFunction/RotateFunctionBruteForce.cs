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
public sealed class RotateFunctionBruteForce : IRotateFunction
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaxRotateFunction(int[] nums)
    {
        var n = nums.Length;

        var maxValue = int.MinValue;

        for (var i = 0; i < n; i++)
        {
            var value = 0;

            for (var j = 0; j < n; j++)
            {
                var index = (j + i) % n;

                var num = nums[index];

                value += num * j;
            }

            maxValue = Math.Max(maxValue, value);
        }

        return maxValue;
    }
}