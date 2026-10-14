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

namespace LeetCode.Algorithms.SortArrayByIncreasingFrequency;

/// <inheritdoc />
public sealed class SortArrayByIncreasingFrequencyDictionary : ISortArrayByIncreasingFrequency
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] FrequencySort(int[] nums)
    {
        var frequencyDictionary = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (!frequencyDictionary.TryAdd(num, 1))
            {
                frequencyDictionary[num]++;
            }
        }

        var keys = new int[frequencyDictionary.Count];

        frequencyDictionary.Keys.CopyTo(keys, 0);

        Array.Sort(
            keys,
            (first, second) =>
            {
                var frequencyComparison = frequencyDictionary[first].CompareTo(frequencyDictionary[second]);

                return frequencyComparison != 0 ? frequencyComparison : second.CompareTo(first);
            });

        var result = new int[nums.Length];
        var resultIndex = 0;

        for (var i = 0; i < keys.Length; i++)
        {
            var key = keys[i];
            var frequency = frequencyDictionary[key];

            for (var j = 0; j < frequency; j++)
            {
                result[resultIndex] = key;

                resultIndex++;
            }
        }

        return result;
    }
}