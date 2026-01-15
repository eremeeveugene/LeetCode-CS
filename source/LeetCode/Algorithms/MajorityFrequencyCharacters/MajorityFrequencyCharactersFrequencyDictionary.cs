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

namespace LeetCode.Algorithms.MajorityFrequencyCharacters;

/// <inheritdoc />
public sealed class MajorityFrequencyCharactersFrequencyDictionary : IMajorityFrequencyCharacters
{
    public string MajorityFrequencyGroup(string s)
    {
        var characterToFrequencyDictionary = new Dictionary<char, int>();

        foreach (var c in s)
        {
            if (!characterToFrequencyDictionary.TryAdd(c, 1))
            {
                characterToFrequencyDictionary[c]++;
            }
        }

        var maxFrequency = 0;
        var maxSize = 0;

        var frequencyToSizeDictionary = new Dictionary<int, int>();

        foreach (var (_, frequency) in characterToFrequencyDictionary)
        {
            if (!frequencyToSizeDictionary.TryAdd(frequency, 1))
            {
                frequencyToSizeDictionary[frequency]++;
            }

            var size = frequencyToSizeDictionary[frequency];

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

        var resultStringBuilder = new StringBuilder();

        foreach (var (character, frequency) in characterToFrequencyDictionary)
        {
            if (frequency == maxFrequency)
            {
                resultStringBuilder.Append(character);
            }
        }

        return resultStringBuilder.ToString();
    }
}