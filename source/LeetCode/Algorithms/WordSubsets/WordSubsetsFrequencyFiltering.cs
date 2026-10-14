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
public sealed class WordSubsetsFrequencyFiltering : IWordSubsets
{
    private const int LettersCount = 'z' - 'a' + 1;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(words1.Length + words2.Length)
    ///     Space complexity - O(words1.Length)
    /// </remarks>
    public IList<string> WordSubsets(string[] words1, string[] words2)
    {
        var maxCharFrequencies = new int[LettersCount];

        for (var i = 0; i < words2.Length; i++)
        {
            var word = words2[i];

            var tempFrequency = new int[maxCharFrequencies.Length];

            for (var j = 0; j < word.Length; j++)
            {
                var c = word[j];

                tempFrequency[c - 'a']++;

                maxCharFrequencies[c - 'a'] = Math.Max(maxCharFrequencies[c - 'a'], tempFrequency[c - 'a']);
            }
        }

        var result = new List<string>();

        for (var i = 0; i < words1.Length; i++)
        {
            var word = words1[i];

            var wordFrequency = new int[maxCharFrequencies.Length];

            for (var j = 0; j < word.Length; j++)
            {
                var c = word[j];

                wordFrequency[c - 'a']++;
            }

            var isUniversal = true;

            for (var j = 0; j < wordFrequency.Length; j++)
            {
                if (wordFrequency[j] >= maxCharFrequencies[j])
                {
                    continue;
                }

                isUniversal = false;

                break;
            }

            if (isUniversal)
            {
                result.Add(word);
            }
        }

        return result;
    }
}