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
public sealed class RelativeSortArrayTwoLoopsSorting : IRelativeSortArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n + n log n)
    ///     Space complexity - O(log n)
    /// </remarks>
    public int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        var result = new List<int>();

        for (var i = 0; i < arr2.Length; i++)
        {
            var arr2Item = arr2[i];

            for (var j = 0; j < arr1.Length; j++)
            {
                if (arr1[j] != arr2Item)
                {
                    continue;
                }

                result.Add(arr1[j]);

                arr1[j] = -1;
            }
        }

        Array.Sort(arr1);

        for (var i = 0; i < arr1.Length; i++)
        {
            var num = arr1[i];

            if (num >= 0)
            {
                result.Add(num);
            }
        }

        return [.. result];
    }
}