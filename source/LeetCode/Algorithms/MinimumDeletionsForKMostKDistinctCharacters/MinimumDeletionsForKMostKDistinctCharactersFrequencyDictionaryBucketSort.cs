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
        var characterToFrequencyDictionary = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];

            if (!characterToFrequencyDictionary.TryAdd(c, 1))
            {
                characterToFrequencyDictionary[c]++;
            }
        }

        var countToRemove = characterToFrequencyDictionary.Count - k;

        if (countToRemove <= 0)
        {
            return 0;
        }

        var buckets = new int[s.Length];

        foreach (var frequency in characterToFrequencyDictionary)
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