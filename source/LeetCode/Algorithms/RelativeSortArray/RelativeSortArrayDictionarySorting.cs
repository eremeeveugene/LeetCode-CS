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
public sealed class RelativeSortArrayDictionarySorting : IRelativeSortArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m + n log n)
    ///     Space complexity - O(log n)
    /// </remarks>
    public int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        var result = new List<int>();
        var remainingItems = new List<int>();

        var countDictionary = new Dictionary<int, int>();

        for (var i = 0; i < arr2.Length; i++)
        {
            var arr2Item = arr2[i];

            countDictionary[arr2Item] = 0;
        }

        for (var i = 0; i < arr1.Length; i++)
        {
            var arr1Item = arr1[i];

            if (countDictionary.TryGetValue(arr1Item, out var value))
            {
                countDictionary[arr1Item] = ++value;
            }
            else
            {
                remainingItems.Add(arr1Item);
            }
        }

        for (var i = 0; i < arr2.Length; i++)
        {
            var arr2Item = arr2[i];
            var count = countDictionary[arr2Item];

            for (var j = 0; j < count; j++)
            {
                result.Add(arr2Item);
            }
        }

        remainingItems.Sort();

        result.AddRange(remainingItems);

        return [.. result];
    }
}