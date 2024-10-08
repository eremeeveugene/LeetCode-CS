﻿// --------------------------------------------------------------------------------
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
public class SortAnArrayMergeSort : ISortAnArray
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] SortArray(int[] nums)
    {
        SortArray(nums, 0, nums.Length - 1);

        return nums;
    }

    private static void SortArray(IList<int> array, int left, int right)
    {
        if (left >= right)
        {
            return;
        }

        var middle = (left + right) / 2;

        SortArray(array, left, middle);
        SortArray(array, middle + 1, right);
        Merge(array, left, middle, right);
    }

    private static void Merge(IList<int> array, int left, int middle, int right)
    {
        var leftSize = middle - left + 1;
        var rightSize = right - middle;

        var leftArray = array.Skip(left).Take(leftSize).ToArray();
        var rightArray = array.Skip(middle + 1).Take(rightSize).ToArray();

        var i = 0;
        var j = 0;
        var k = left;

        while (i < leftSize && j < rightSize)
        {
            if (leftArray[i] > rightArray[j])
            {
                array[k] = rightArray[j];

                j++;
            }
            else
            {
                array[k] = leftArray[i];

                i++;
            }

            k++;
        }

        while (i < leftSize)
        {
            array[k] = leftArray[i];

            i++;
            k++;
        }

        while (j < rightSize)
        {
            array[k] = rightArray[j];

            j++;
            k++;
        }
    }
}