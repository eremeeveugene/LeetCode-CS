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

namespace LeetCode.Algorithms.LongestPalindromeByConcatenatingTwoLetterWords;

/// <inheritdoc />
public class LongestPalindromeByConcatenatingTwoLetterWordsFrequencyDictionary :
    ILongestPalindromeByConcatenatingTwoLetterWords
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="words"></param>
    /// <returns></returns>
    public int LongestPalindrome(string[] words)
    {
        var longestPalindrome = 0;

        var frequencyDictionary = new Dictionary<string, int>();

        foreach (var word in words)
        {
            var reversedWord = new string([word[1], word[0]]);

            if (frequencyDictionary.TryGetValue(reversedWord, out var count) && count > 0)
            {
                longestPalindrome += 4;

                frequencyDictionary[reversedWord] = count - 1;
            }
            else
            {
                if (!frequencyDictionary.TryAdd(word, 1))
                {
                    frequencyDictionary[word]++;
                }
            }
        }

        if (frequencyDictionary.Any(frequency => frequency.Value > 0 && frequency.Key[0] == frequency.Key[1]))
        {
            return longestPalindrome + 2;
        }

        return longestPalindrome;
    }
}