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

                maxCharFrequencies[c - 'a'] = Math.Max(maxCharFrequencies[c - 'a'], tempFrequency[c - 'a']);
            }
        }

        var result = new List<string>();

        foreach (var word in words1)
        {
            var wordFrequency = new int[maxCharFrequencies.Length];

            foreach (var c in word)
            {
                wordFrequency[c - 'a']++;
            }

            if (wordFrequency.Where((t, i) => t < maxCharFrequencies[i]).Any())
            {
                continue;
            }

            result.Add(word);
        }

        return result;
    }
}