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
public class PartitionArrayAccordingToGivenPivotDynamicLists : IPartitionArrayAccordingToGivenPivot
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="pivot"></param>
    /// <returns></returns>
    public int[] PivotArray(int[] nums, int pivot)
    {
        var lessThanPivotList = new List<int>();
        var equalToPivotList = new List<int>();
        var greaterThanPivotList = new List<int>();

        foreach (var num in nums)
        {
            if (num < pivot)
            {
                lessThanPivotList.Add(num);
            }
            else if (num > pivot)
            {
                greaterThanPivotList.Add(num);
            }
            else
            {
                equalToPivotList.Add(num);
            }
        }

        var lessThanPivotListIndex = 0;

        while (lessThanPivotListIndex < lessThanPivotList.Count)
        {
            nums[lessThanPivotListIndex] = lessThanPivotList[lessThanPivotListIndex];

            lessThanPivotListIndex++;
        }

        var equalToPivotListIndex = 0;

        while (equalToPivotListIndex < equalToPivotList.Count)
        {
            nums[equalToPivotListIndex + lessThanPivotListIndex] = equalToPivotList[equalToPivotListIndex];

            equalToPivotListIndex++;
        }

        var greaterThanPivotListIndex = 0;

        while (greaterThanPivotListIndex < greaterThanPivotList.Count)
        {
            nums[greaterThanPivotListIndex + equalToPivotListIndex + lessThanPivotListIndex] =
                greaterThanPivotList[greaterThanPivotListIndex];

            greaterThanPivotListIndex++;
        }

        return nums;
    }
}