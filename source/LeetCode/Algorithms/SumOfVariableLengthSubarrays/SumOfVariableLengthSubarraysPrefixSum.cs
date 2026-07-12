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

namespace LeetCode.Algorithms.SumOfVariableLengthSubarrays;

/// <inheritdoc />
public sealed class SumOfVariableLengthSubarraysPrefixSum : ISumOfVariableLengthSubarrays
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int SubarraySum(int[] nums)
    {
        var prefix = new int[nums.Length];

        prefix[0] = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            prefix[i] = prefix[i - 1] + nums[i];
        }

        var sum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var start = Math.Max(0, i - nums[i]);

            sum += prefix[i] - (start > 0 ? prefix[start - 1] : 0);
        }

        return sum;
    }
}