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

namespace LeetCode.Algorithms.PartitionArrayAccordingToGivenPivot;

/// <inheritdoc />
public sealed class PartitionArrayAccordingToGivenPivotThreePass : IPartitionArrayAccordingToGivenPivot
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] PivotArray(int[] nums, int pivot)
    {
        var n = nums.Length;

        var result = new int[n];

        var resultIndex = 0;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            if (num < pivot)
            {
                result[resultIndex++] = num;
            }
        }

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            if (num == pivot)
            {
                result[resultIndex++] = num;
            }
        }

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            if (num > pivot)
            {
                result[resultIndex++] = num;
            }
        }

        return result;
    }
}