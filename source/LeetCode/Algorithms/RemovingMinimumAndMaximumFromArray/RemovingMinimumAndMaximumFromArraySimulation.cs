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

namespace LeetCode.Algorithms.RemovingMinimumAndMaximumFromArray;

/// <inheritdoc />
public sealed class RemovingMinimumAndMaximumFromArraySimulation : IRemovingMinimumAndMaximumFromArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinimumDeletions(int[] nums)
    {
        var n = nums.Length;

        if (n < 3)
        {
            return n;
        }

        var min = int.MaxValue;
        var minIndex = 0;
        var max = int.MinValue;
        var maxIndex = 0;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            if (num < min)
            {
                min = num;
                minIndex = i;
            }

            if (num <= max)
            {
                continue;
            }

            max = num;
            maxIndex = i;
        }

        var leftIndex = Math.Min(minIndex, maxIndex);
        var rightIndex = Math.Max(minIndex, maxIndex);

        var deleteFromLeft = rightIndex + 1;
        var deleteFromRight = n - leftIndex;
        var deleteFromBothEnds = leftIndex + 1 + n - rightIndex;

        return Math.Min(deleteFromBothEnds, Math.Min(deleteFromLeft, deleteFromRight));
    }
}