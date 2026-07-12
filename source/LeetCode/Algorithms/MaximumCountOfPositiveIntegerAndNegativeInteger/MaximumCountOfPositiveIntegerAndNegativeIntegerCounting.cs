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

namespace LeetCode.Algorithms.MaximumCountOfPositiveIntegerAndNegativeInteger;

/// <inheritdoc />
public sealed class MaximumCountOfPositiveIntegerAndNegativeIntegerCounting : IMaximumCountOfPositiveIntegerAndNegativeInteger
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaximumCount(int[] nums)
    {
        var negativeCount = 0;

        while (negativeCount < nums.Length && nums[negativeCount] < 0)
        {
            negativeCount++;
        }

        var zeroCount = 0;

        while (zeroCount + negativeCount < nums.Length && nums[zeroCount + negativeCount] == 0)
        {
            zeroCount++;
        }

        var positiveCount = nums.Length - zeroCount - negativeCount;

        return Math.Max(negativeCount, positiveCount);
    }
}