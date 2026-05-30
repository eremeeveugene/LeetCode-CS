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
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int MaxDifference(string s)
    {
        var frequencyDictionary = new Dictionary<int, int>();

        foreach (var c in s.Where(c => !frequencyDictionary.TryAdd(c, 1)))
        {
            frequencyDictionary[c]++;
        }

        var oddFrequency = int.MinValue;
        var evenFrequency = int.MaxValue;

        foreach (var frequency in frequencyDictionary)
        {
            if (frequency.Value % 2 == 0)
            {
                evenFrequency = Math.Min(evenFrequency, frequency.Value);
            }
            else
            {
                oddFrequency = Math.Max(oddFrequency, frequency.Value);
            }
        }

        return oddFrequency - evenFrequency;
    }
}