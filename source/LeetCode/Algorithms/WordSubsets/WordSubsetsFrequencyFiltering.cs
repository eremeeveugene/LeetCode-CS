// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.WordSubsets;

/// <inheritdoc />
public class WordSubsetsFrequencyFiltering : IWordSubsets
{
    private const int LettersCount = 'z' - 'a' + 1;

    /// <summary>
    ///     Time complexity - O(words1.Length + words2.Length)
    ///     Space complexity - O(words1.Length)
    /// </summary>
    /// <param name="words1"></param>
    /// <param name="words2"></param>
    /// <returns></returns>
    public IList<string> WordSubsets(string[] words1, string[] words2)
    {
        var maxCharFrequencies = new int[LettersCount];

        foreach (var word in words2)
        {
            var tempFrequency = new int[maxCharFrequencies.Length];

            foreach (var c in word)
            {
                tempFrequency[c - 'a']++;
            }

            for (var i = 0; i < maxCharFrequencies.Length; i++)
            {
                maxCharFrequencies[i] = Math.Max(maxCharFrequencies[i], tempFrequency[i]);
            }
        }

        return words1.Where(word => IsUniversal(word, maxCharFrequencies)).ToArray();
    }

    private static bool IsUniversal(string word, int[] maxCharFrequencies)
    {
        var wordFrequency = new int[maxCharFrequencies.Length];

        foreach (var c in word)
        {
            wordFrequency[c - 'a']++;
        }

        return !maxCharFrequencies.Where((t, i) => wordFrequency[i] < t).Any();
    }
}