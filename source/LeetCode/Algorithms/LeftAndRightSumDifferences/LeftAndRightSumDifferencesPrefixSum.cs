// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.LeftAndRightSumDifferences;

/// <inheritdoc />
public class LeftAndRightSumDifferencesPrefixSum : ILeftAndRightSumDifferences
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] LeftRightDifference(int[] nums)
    {
        var leftSum = new int[nums.Length];

        for (var i = 0; i < nums.Length - 1; i++)
        {
            leftSum[i + 1] = leftSum[i] + nums[i];
        }

        var rightSum = new int[nums.Length];

        for (var i = nums.Length - 1; i > 0; i--)
        {
            rightSum[i - 1] = rightSum[i] + nums[i];
        }

        var result = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            result[i] = Math.Abs(leftSum[i] - rightSum[i]);
        }

        return result;
    }
}