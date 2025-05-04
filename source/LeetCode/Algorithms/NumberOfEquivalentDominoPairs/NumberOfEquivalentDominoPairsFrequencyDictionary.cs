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

namespace LeetCode.Algorithms.NumberOfEquivalentDominoPairs;

/// <inheritdoc />
public class NumberOfEquivalentDominoPairsFrequencyDictionary : INumberOfEquivalentDominoPairs
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="dominoes"></param>
    /// <returns></returns>
    public int NumEquivDominoPairs(int[][] dominoes)
    {
        var result = 0;

        var frequencyDictionary = new Dictionary<(int, int), int>();

        foreach (var domino in dominoes)
        {
            var a = Math.Min(domino[0], domino[1]);
            var b = Math.Max(domino[0], domino[1]);
            var key = (a, b);

            if (frequencyDictionary.TryGetValue(key, out var frequency))
            {
                result += frequency;

                frequencyDictionary[key] = frequency + 1;
            }
            else
            {
                frequencyDictionary[key] = 1;
            }
        }

        return result;
    }
}