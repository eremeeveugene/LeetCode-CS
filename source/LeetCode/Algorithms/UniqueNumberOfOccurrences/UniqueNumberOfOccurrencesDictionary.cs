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

namespace LeetCode.Algorithms.UniqueNumberOfOccurrences;

/// <inheritdoc />
public sealed class UniqueNumberOfOccurrencesDictionary : IUniqueNumberOfOccurrences
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public bool UniqueOccurrences(int[] arr)
    {
        var occurenceDictionary = new Dictionary<int, int>();

        for (var i = 0; i < arr.Length; i++)
        {
            var number = arr[i];

            if (!occurenceDictionary.TryAdd(number, 1))
            {
                occurenceDictionary[number]++;
            }
        }

        var occurenceHashSet = new HashSet<int>();

        return occurenceDictionary.All(occurence => occurenceHashSet.Add(occurence.Value));
    }
}