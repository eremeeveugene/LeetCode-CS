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

namespace LeetCode.Algorithms.NumberOfWaysToSplitArray;

/// <inheritdoc />
public sealed class NumberOfWaysToSplitArrayPrefixSum : INumberOfWaysToSplitArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int WaysToSplitArray(int[] nums)
    {
        long leftSum = nums[0];
        long rightSum = 0;

        for (var i = 1; i < nums.Length; i++)
        {
            rightSum += nums[i];
        }

        var result = 0;

        for (var i = 1; i < nums.Length; i++)
        {
            if (leftSum >= rightSum)
            {
                result++;
            }

            leftSum += nums[i];
            rightSum -= nums[i];
        }

        return result;
    }
}