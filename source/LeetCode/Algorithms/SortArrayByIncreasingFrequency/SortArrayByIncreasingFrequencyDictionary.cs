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

namespace LeetCode.Algorithms.SortArrayByIncreasingFrequency;

/// <inheritdoc />
public class SortArrayByIncreasingFrequencyDictionary : ISortArrayByIncreasingFrequency
{
    /// <summary>
    ///     Time complexity - O(n log n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] FrequencySort(int[] nums)
    {
        var frequencyDictionary = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (!frequencyDictionary.TryAdd(num, 1))
            {
                frequencyDictionary[num]++;
            }
        }

        return frequencyDictionary.OrderBy(f => f.Value).ThenByDescending(f => f.Key)
            .SelectMany(pair => Enumerable.Repeat(pair.Key, pair.Value))
            .ToArray();
    }
}