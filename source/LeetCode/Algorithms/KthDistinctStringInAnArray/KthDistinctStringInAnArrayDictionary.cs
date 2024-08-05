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

namespace LeetCode.Algorithms.KthDistinctStringInAnArray;

/// <inheritdoc />
public class KthDistinctStringInAnArrayDictionary : IKthDistinctStringInAnArray
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public string KthDistinct(string[] arr, int k)
    {
        var countDictionary = new Dictionary<string, int>();

        foreach (var item in arr)
        {
            if (!countDictionary.TryAdd(item, 1))
            {
                countDictionary[item]++;
            }
        }

        var distinctCount = 0;

        foreach (var item in arr)
        {
            if (countDictionary[item] != 1)
            {
                continue;
            }

            distinctCount++;

            if (distinctCount == k)
            {
                return item;
            }
        }

        return string.Empty;
    }
}