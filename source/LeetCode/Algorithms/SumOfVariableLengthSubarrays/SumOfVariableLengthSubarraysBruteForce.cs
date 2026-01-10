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
public sealed class SumOfVariableLengthSubarraysBruteForce : ISumOfVariableLengthSubarrays
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int SubarraySum(int[] nums)
    {
        var sum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var start = Math.Max(0, i - nums[i]);

            for (var j = start; j <= i; j++)
            {
                sum += nums[j];
            }
        }

        return sum;
    }
}