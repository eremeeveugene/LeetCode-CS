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
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n + m log m)
    ///     Space complexity - O((n + m) * log (n + m))
    /// </remarks>
    public int[][] MergeArrays(int[][] nums1, int[][] nums2)
    {
        var dictionary = new SortedDictionary<int, int>();

        for (var i = 0; i < nums1.Length; i++)
        {
            var num = nums1[i];

            dictionary[num[0]] = num[1];
        }

        for (var i = 0; i < nums2.Length; i++)
        {
            var num = nums2[i];

            if (dictionary.ContainsKey(num[0]))
            {
                dictionary[num[0]] += num[1];
            }
            else
            {
                dictionary[num[0]] = num[1];
            }
        }

        var keys = new int[dictionary.Count];
        var values = new int[dictionary.Count];

        dictionary.Keys.CopyTo(keys, 0);
        dictionary.Values.CopyTo(values, 0);

        var result = new int[dictionary.Count][];

        for (var i = 0; i < keys.Length; i++)
        {
            result[i] = [keys[i], values[i]];
        }

        return result;
    }
}