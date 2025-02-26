// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class MaximumAbsoluteSumOfAnySubarrayKadaneAlgorithm : IMaximumAbsoluteSumOfAnySubarray
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MaxAbsoluteSum(int[] nums)
    {
        var maxSum = 0;
        var minSum = 0;
        var currentMax = 0;
        var currentMin = 0;

        foreach (var num in nums)
        {
            currentMax = Math.Max(0, currentMax + num);
            currentMin = Math.Min(0, currentMin + num);
            maxSum = Math.Max(maxSum, currentMax);
            minSum = Math.Min(minSum, currentMin);
        }

        return Math.Max(maxSum, Math.Abs(minSum));
    }
}