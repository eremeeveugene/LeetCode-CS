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

namespace LeetCode.Algorithms.CountPartitionsWithEvenSumDifference;

/// <inheritdoc />
public sealed class CountPartitionsWithEvenSumDifferencePrefixSum : ICountPartitionsWithEvenSumDifference
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int CountPartitions(int[] nums)
    {
        var left = nums[0];

        var sum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            sum += num;
        }

        var right = sum - nums[0];

        var count = 0;

        for (var i = 1; i < nums.Length; i++)
        {
            if ((left - right) % 2 == 0)
            {
                count++;
            }

            left += nums[i];
            right -= nums[i];
        }

        return count;
    }
}