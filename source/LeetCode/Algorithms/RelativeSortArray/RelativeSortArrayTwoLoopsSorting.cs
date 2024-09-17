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

namespace LeetCode.Algorithms.RelativeSortArray;

/// <inheritdoc />
public class RelativeSortArrayTwoLoopsSorting : IRelativeSortArray
{
    /// <summary>
    ///     Time complexity - O(m * n + n log n)
    ///     Space complexity - O(log n)
    /// </summary>
    /// <param name="arr1"></param>
    /// <param name="arr2"></param>
    /// <returns></returns>
    public int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        var result = new List<int>();

        foreach (var arr2Item in arr2)
        {
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

        result.AddRange(arr1.Where(a => a >= 0));

        return [.. result];
    }
}