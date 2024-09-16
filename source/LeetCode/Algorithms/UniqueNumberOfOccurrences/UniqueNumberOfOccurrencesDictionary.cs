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

namespace LeetCode.Algorithms.UniqueNumberOfOccurrences;

/// <inheritdoc />
public class UniqueNumberOfOccurrencesDictionary : IUniqueNumberOfOccurrences
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public bool UniqueOccurrences(int[] arr)
    {
        var occurenceDictionary = new Dictionary<int, int>();

        foreach (var number in arr)
        {
            if (!occurenceDictionary.TryAdd(number, 1))
            {
                occurenceDictionary[number]++;
            }
        }

        var occurenceHashSet = new HashSet<int>();

        return occurenceDictionary.All(occurence => occurenceHashSet.Add(occurence.Value));
    }
}