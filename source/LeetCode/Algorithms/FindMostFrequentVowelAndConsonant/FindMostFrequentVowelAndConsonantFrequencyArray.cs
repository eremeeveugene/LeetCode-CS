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

namespace LeetCode.Algorithms.FindMostFrequentVowelAndConsonant;

/// <inheritdoc />
public class FindMostFrequentVowelAndConsonantFrequencyArray : IFindMostFrequentVowelAndConsonant
{
    private const byte AlphabetLength = 'z' - 'a' + 1;

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int MaxFreqSum(string s)
    {
        Span<byte> frequencyArray = stackalloc byte[AlphabetLength];

        var maxVowel = 0;
        var maxConsonant = 0;

        foreach (var c in s)
        {
            var index = c - 'a';

            frequencyArray[index]++;

            if (IsVowel(c))
            {
                maxVowel = Math.Max(maxVowel, frequencyArray[index]);
            }
            else
            {
                maxConsonant = Math.Max(maxConsonant, frequencyArray[index]);
            }
        }

        return maxVowel + maxConsonant;
    }

    private static bool IsVowel(char c)
    {
        return c is 'a' or 'e' or 'i' or 'o' or 'u';
    }
}