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

namespace LeetCode.Algorithms.FindMostFrequentVowelAndConsonant;

/// <inheritdoc />
public sealed class FindMostFrequentVowelAndConsonantFrequencyDictionary : IFindMostFrequentVowelAndConsonant
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int MaxFreqSum(string s)
    {
        var frequencyDictionary = new Dictionary<char, int>();

        var maxVowel = 0;
        var maxConsonant = 0;

        foreach (var c in s)
        {
            if (!frequencyDictionary.TryAdd(c, 1))
            {
                frequencyDictionary[c]++;
            }

            if (IsVowel(c))
            {
                maxVowel = Math.Max(maxVowel, frequencyDictionary[c]);
            }
            else
            {
                maxConsonant = Math.Max(maxConsonant, frequencyDictionary[c]);
            }
        }

        return maxVowel + maxConsonant;
    }

    private static bool IsVowel(char c)
    {
        return c is 'a' or 'e' or 'i' or 'o' or 'u';
    }
}