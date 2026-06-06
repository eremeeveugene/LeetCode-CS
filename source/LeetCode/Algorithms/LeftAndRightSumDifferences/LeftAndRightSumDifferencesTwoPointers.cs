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

namespace LeetCode.Algorithms.LeftAndRightSumDifferences;

/// <inheritdoc />
public sealed class LeftAndRightSumDifferencesTwoPointers : ILeftAndRightSumDifferences
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int[] LeftRightDifference(int[] nums)
    {
        var n = nums.Length;

        var leftSum = 0;
        var rightSum = 0;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            rightSum += num;
        }

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            rightSum -= num;

            nums[i] = Math.Abs(leftSum - rightSum);

            leftSum += num;
        }

        return nums;
    }
}