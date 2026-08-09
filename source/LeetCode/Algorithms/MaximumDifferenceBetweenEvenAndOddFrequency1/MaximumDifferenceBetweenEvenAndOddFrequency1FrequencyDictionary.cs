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

namespace LeetCode.Algorithms.MaximumDifferenceBetweenEvenAndOddFrequency1;

/// <inheritdoc />
public sealed class MaximumDifferenceBetweenEvenAndOddFrequency1FrequencyDictionary : IMaximumDifferenceBetweenEvenAndOddFrequency1
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int MaxDifference(string s)
    {
        var frequencyDictionary = new Dictionary<int, int>();

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];

            if (!frequencyDictionary.TryAdd(c, 1))
            {
                frequencyDictionary[c]++;
            }
        }

        var oddFrequency = 0;
        var evenFrequency = s.Length;

        var frequencies = new int[frequencyDictionary.Count];

        frequencyDictionary.Values.CopyTo(frequencies, 0);

        for (var i = 0; i < frequencies.Length; i++)
        {
            var frequency = frequencies[i];

            if (frequency % 2 == 0)
            {
                evenFrequency = Math.Min(evenFrequency, frequency);
            }
            else
            {
                oddFrequency = Math.Max(oddFrequency, frequency);
            }
        }

        return oddFrequency - evenFrequency;
    }
}