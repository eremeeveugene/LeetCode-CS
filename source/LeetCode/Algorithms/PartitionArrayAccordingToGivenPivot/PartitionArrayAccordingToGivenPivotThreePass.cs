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
        var result = new int[nums.Length];

        var resultIndex = 0;

        foreach (var num in nums)
        {
            if (num < pivot)
            {
                result[resultIndex++] = num;
            }
        }

        foreach (var num in nums)
        {
            if (num == pivot)
            {
                result[resultIndex++] = num;
            }
        }

        foreach (var num in nums)
        {
            if (num > pivot)
            {
                result[resultIndex++] = num;
            }
        }

        return result;
    }
}