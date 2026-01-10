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

namespace LeetCode.Algorithms.RabbitsInForest;

/// <inheritdoc />
public sealed class RabbitsInForestFrequencyDictionary : IRabbitsInForest
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="answers"></param>
    /// <returns></returns>
    public int NumRabbits(int[] answers)
    {
        var frequencyDictionary = new Dictionary<int, int>();

        foreach (var answer in answers)
        {
            if (!frequencyDictionary.TryAdd(answer, 1))
            {
                frequencyDictionary[answer]++;
            }
        }

        var rabbits = 0;

        foreach (var frequency in frequencyDictionary)
        {
            var groupSize = frequency.Key + 1;
            var groups = (frequency.Value + groupSize - 1) / groupSize;

            rabbits += groups * groupSize;
        }

        return rabbits;
    }
}