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

using System.Text;

namespace LeetCode.Algorithms.MostCommonWord;

/// <inheritdoc />
public class MostCommonWordDictionary : IMostCommonWord
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="paragraph"></param>
    /// <param name="banned"></param>
    /// <returns></returns>
    public string MostCommonWord(string paragraph, string[] banned)
    {
        var mostCommonWord = string.Empty;
        var mostFrequency = 0;

        var wordsFrequencyDictionary = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        var bannedHashSet = new HashSet<string>(banned, StringComparer.OrdinalIgnoreCase);

        var currentWordStringBuilder = new StringBuilder();

        foreach (var character in paragraph)
        {
            if (char.IsLetter(character))
            {
                currentWordStringBuilder.Append(char.ToLowerInvariant(character));
            }
            else if (currentWordStringBuilder.Length > 0)
            {
                ProcessWord(currentWordStringBuilder, bannedHashSet, wordsFrequencyDictionary, ref mostCommonWord,
                    ref mostFrequency);
            }
        }

        if (currentWordStringBuilder.Length > 0)
        {
            ProcessWord(currentWordStringBuilder, bannedHashSet, wordsFrequencyDictionary, ref mostCommonWord,
                ref mostFrequency);
        }

        return mostCommonWord;
    }

    private static void ProcessWord(StringBuilder currentWordStringBuilder,
        HashSet<string> bannedHashSet,
        Dictionary<string, int> wordsFrequencyDictionary,
        ref string mostCommonWord,
        ref int mostFrequency)
    {
        var word = currentWordStringBuilder.ToString();

        currentWordStringBuilder.Clear();

        if (bannedHashSet.Contains(word))
        {
            return;
        }

        if (!wordsFrequencyDictionary.TryAdd(word, 1))
        {
            wordsFrequencyDictionary[word]++;
        }

        if (wordsFrequencyDictionary[word] <= mostFrequency)
        {
            return;
        }

        mostFrequency = wordsFrequencyDictionary[word];
        mostCommonWord = word;
    }
}