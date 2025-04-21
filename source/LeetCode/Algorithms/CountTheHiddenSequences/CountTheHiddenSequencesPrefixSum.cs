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

namespace LeetCode.Algorithms.CountTheHiddenSequences;

/// <inheritdoc />
public class CountTheHiddenSequencesPrefixSum : ICountTheHiddenSequences
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="differences"></param>
    /// <param name="lower"></param>
    /// <param name="upper"></param>
    /// <returns></returns>
    public int NumberOfArrays(int[] differences, int lower, int upper)
    {
        var minPrefix = 0;
        var maxPrefix = 0;
        var prefixSum = 0;
        var bound = upper - lower;

        foreach (var difference in differences)
        {
            prefixSum += difference;

            minPrefix = Math.Min(minPrefix, prefixSum);
            maxPrefix = Math.Max(maxPrefix, prefixSum);

            if (maxPrefix - minPrefix > bound)
            {
                return 0;
            }
        }

        return bound - (maxPrefix - minPrefix) + 1;
    }
}