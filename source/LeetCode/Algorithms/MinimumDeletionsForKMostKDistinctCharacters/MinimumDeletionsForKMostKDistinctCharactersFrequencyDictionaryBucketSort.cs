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

namespace LeetCode.Algorithms.MinimumDeletionsForKMostKDistinctCharacters;

/// <inheritdoc />
public sealed class MinimumDeletionsForKMostKDistinctCharactersFrequencyDictionaryBucketSort : IMinimumDeletionsForKMostKDistinctCharacters
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int MinDeletion(string s, int k)
    {
        var frequencyDictionary = new Dictionary<char, int>();

        foreach (var c in s.Where(c => !frequencyDictionary.TryAdd(c, 1)))
        {
            frequencyDictionary[c]++;
        }

        if (frequencyDictionary.Count <= k)
        {
            return 0;
        }

        var countToRemove = frequencyDictionary.Values.Count(frequency => frequency > 0) - k;

        if (countToRemove <= 0)
        {
            return 0;
        }

        var buckets = new int[s.Length];

        foreach (var frequency in frequencyDictionary)
        {
            buckets[frequency.Value - 1]++;
        }

        var result = 0;

        for (var i = 0; i < s.Length && countToRemove > 0; i++)
        {
            while (buckets[i] > 0 && countToRemove > 0)
            {
                result += i + 1;

                buckets[i]--;

                countToRemove--;
            }
        }

        return result;
    }
}