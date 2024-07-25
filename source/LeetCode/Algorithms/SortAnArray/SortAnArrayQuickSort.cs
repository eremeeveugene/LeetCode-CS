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

namespace LeetCode.Algorithms.SortAnArray;

/// <inheritdoc />
public class SortAnArrayQuickSort : ISortAnArray
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n log n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] SortArray(int[] nums)
    {
        SortArray(nums, 0, nums.Length - 1);

        return nums;
    }

    private static void SortArray(IList<int> nums, int left, int right)
    {
        if (left >= right)
        {
            return;
        }

        var partitionIndex = Partition(nums, left, right);

        SortArray(nums, left, partitionIndex - 1);
        SortArray(nums, partitionIndex + 1, right);
    }

    private static int Partition(IList<int> array, int low, int high)
    {
        for (var j = low; j < high; j++)
        {
            if (array[j] > array[high])
            {
                continue;
            }

            (array[low], array[j]) = (array[j], array[low]);

            low++;
        }

        (array[low], array[high]) = (array[high], array[low]);

        return low;
    }
}