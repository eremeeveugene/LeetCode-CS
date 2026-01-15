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

namespace LeetCode.Algorithms.MajorityFrequencyCharacters;

/// <inheritdoc />
public sealed class MajorityFrequencyCharactersFrequencySpan : IMajorityFrequencyCharacters
{
    private const int AlphabetSize = 26;
    private const char FirstLetter = 'a';

    public string MajorityFrequencyGroup(string s)
    {
        Span<int> letterFrequencies = stackalloc int[AlphabetSize];

        for (var i = 0; i < s.Length; i++)
        {
            var letter = s[i] - FirstLetter;

            letterFrequencies[letter]++;
        }

        Span<int> groupSizes = stackalloc int[s.Length + 1];

        for (var i = 0; i < AlphabetSize; i++)
        {
            var frequency = letterFrequencies[i];

            if (frequency <= 0)
            {
                continue;
            }

            groupSizes[frequency]++;
        }

        var maxFrequency = 0;
        var maxSize = 0;

        for (var frequency = 1; frequency < s.Length + 1; frequency++)
        {
            var size = groupSizes[frequency];

            if (size < maxSize)
            {
                continue;
            }

            if (size == maxSize && frequency <= maxFrequency)
            {
                continue;
            }

            maxFrequency = frequency;
            maxSize = size;
        }

        Span<char> resultBuffer = stackalloc char[AlphabetSize];

        var resultLength = 0;

        for (var i = 0; i < AlphabetSize; i++)
        {
            if (letterFrequencies[i] != maxFrequency)
            {
                continue;
            }

            var character = (char)(FirstLetter + i);

            resultBuffer[resultLength] = character;

            resultLength++;
        }

        return new string(resultBuffer[..resultLength]);
    }
}