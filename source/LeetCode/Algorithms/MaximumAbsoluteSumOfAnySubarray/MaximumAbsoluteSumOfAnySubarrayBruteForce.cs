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

namespace LeetCode.Algorithms.MaximumAbsoluteSumOfAnySubarray;

/// <inheritdoc />
public sealed class MaximumAbsoluteSumOfAnySubarrayBruteForce : IMaximumAbsoluteSumOfAnySubarray
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MaxAbsoluteSum(int[] nums)
    {
        var maxAbsoluteSum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var currentSum = 0;

            for (var j = i; j < nums.Length; j++)
            {
                currentSum += nums[j];

                maxAbsoluteSum = Math.Max(maxAbsoluteSum, Math.Abs(currentSum));
            }
        }

        return maxAbsoluteSum;
    }
}