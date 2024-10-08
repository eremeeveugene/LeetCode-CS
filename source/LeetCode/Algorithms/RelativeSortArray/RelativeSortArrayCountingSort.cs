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

namespace LeetCode.Algorithms.RelativeSortArray;

/// <inheritdoc />
public class RelativeSortArrayCountingSort : IRelativeSortArray
{
    /// <summary>
    ///     Time complexity - O(n + m + k), where k is the maximum element in arr1
    ///     Space complexity - O(k), where k is the maximum element in arr1
    /// </summary>
    /// <param name="arr1"></param>
    /// <param name="arr2"></param>
    /// <returns></returns>
    public int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        var frequency = new int[1001];

        foreach (var arr1Item in arr1)
        {
            frequency[arr1Item]++;
        }

        var index = 0;

        foreach (var num in arr2)
        {
            while (frequency[num] > 0)
            {
                arr1[index++] = num;

                frequency[num]--;
            }
        }

        for (var i = 0; i < frequency.Length; i++)
        {
            while (frequency[i] > 0)
            {
                arr1[index++] = i;

                frequency[i]--;
            }
        }

        return arr1;
    }
}