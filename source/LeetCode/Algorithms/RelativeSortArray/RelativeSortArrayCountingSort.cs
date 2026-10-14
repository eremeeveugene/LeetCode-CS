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

namespace LeetCode.Algorithms.RelativeSortArray;

/// <inheritdoc />
public sealed class RelativeSortArrayCountingSort : IRelativeSortArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + m + k), where k is the maximum element in arr1
    ///     Space complexity - O(k), where k is the maximum element in arr1
    /// </remarks>
    public int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        var frequency = new int[1001];

        for (var i = 0; i < arr1.Length; i++)
        {
            var arr1Item = arr1[i];

            frequency[arr1Item]++;
        }

        var index = 0;

        for (var i = 0; i < arr2.Length; i++)
        {
            var num = arr2[i];

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