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

namespace LeetCode.Algorithms.MergeTwo2DArraysBySummingValues;

/// <inheritdoc />
public sealed class MergeTwo2DArraysBySummingValuesSortedDictionary : IMergeTwo2DArraysBySummingValues
{
    /// <summary>
    ///     Time complexity - O(n log n + m log m)
    ///     Space complexity - O((n + m) * log (n + m))
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="nums2"></param>
    /// <returns></returns>
    public int[][] MergeArrays(int[][] nums1, int[][] nums2)
    {
        var dictionary = new SortedDictionary<int, int>();

        foreach (var num in nums1)
        {
            dictionary[num[0]] = num[1];
        }

        foreach (var num in nums2)
        {
            if (dictionary.ContainsKey(num[0]))
            {
                dictionary[num[0]] += num[1];
            }
            else
            {
                dictionary[num[0]] = num[1];
            }
        }

        var result = new int[dictionary.Count][];

        var i = 0;

        foreach (var keyValuePair in dictionary)
        {
            result[i] = [keyValuePair.Key, keyValuePair.Value];

            i++;
        }

        return result;
    }
}