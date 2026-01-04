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

namespace LeetCode.Algorithms.NumberOfEquivalentDominoPairs;

/// <inheritdoc />
public class NumberOfEquivalentDominoPairsFrequencyArray : INumberOfEquivalentDominoPairs
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="dominoes"></param>
    /// <returns></returns>
    public int NumEquivDominoPairs(int[][] dominoes)
    {
        var result = 0;

        var frequencyArray = new int[100];

        foreach (var domino in dominoes)
        {
            var a = Math.Min(domino[0], domino[1]);
            var b = Math.Max(domino[0], domino[1]);
            var key = (a * 10) + b;

            result += frequencyArray[key];

            frequencyArray[key]++;
        }

        return result;
    }
}