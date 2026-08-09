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

namespace LeetCode.Algorithms.KthDistinctStringInAnArray;

/// <inheritdoc />
public sealed class KthDistinctStringInAnArrayDictionary : IKthDistinctStringInAnArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public string KthDistinct(string[] arr, int k)
    {
        var n = arr.Length;

        var countDictionary = new Dictionary<string, int>();

        for (var i = 0; i < n; i++)
        {
            var num = arr[i];

            if (!countDictionary.TryAdd(num, 1))
            {
                countDictionary[num]++;
            }
        }

        for (var i = 0; i < n; i++)
        {
            var num = arr[i];

            if (countDictionary[num] != 1)
            {
                continue;
            }

            k--;

            if (k == 0)
            {
                return num;
            }
        }

        return string.Empty;
    }
}