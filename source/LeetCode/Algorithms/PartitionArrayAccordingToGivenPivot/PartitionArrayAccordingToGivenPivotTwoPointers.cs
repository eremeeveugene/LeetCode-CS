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

namespace LeetCode.Algorithms.PartitionArrayAccordingToGivenPivot;

/// <inheritdoc />
public class PartitionArrayAccordingToGivenPivotTwoPointers : IPartitionArrayAccordingToGivenPivot
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="pivot"></param>
    /// <returns></returns>
    public int[] PivotArray(int[] nums, int pivot)
    {
        var result = new int[nums.Length];
        var leftIndex = 0;
        var rightIndex = nums.Length - 1;

        for (int i = 0, j = nums.Length - 1; i < nums.Length; i++, j--)
        {
            if (nums[i] < pivot)
            {
                result[leftIndex] = nums[i];
                leftIndex++;
            }

            if (nums[j] > pivot)
            {
                result[rightIndex] = nums[j];
                rightIndex--;
            }
        }

        while (leftIndex <= rightIndex)
        {
            result[leftIndex] = pivot;
            leftIndex++;
        }

        return result;
    }
}