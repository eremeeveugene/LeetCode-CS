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
public sealed class MaximumDifferenceBetweenEvenAndOddFrequency1FrequencyArray : IMaximumDifferenceBetweenEvenAndOddFrequency1
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaxDifference(string s)
    {
        var frequencyArray = new int['z' - 'a' + 1];

        foreach (var c in s)
        {
            frequencyArray['z' - c]++;
        }

        var oddFrequency = 0;
        var evenFrequency = s.Length;

        foreach (var frequency in frequencyArray)
        {
            if (frequency == 0)
            {
                continue;
            }

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