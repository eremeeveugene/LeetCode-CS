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

namespace LeetCode.Algorithms.DistributeCandies;

/// <inheritdoc />
public sealed class DistributeCandiesDictionary : IDistributeCandies
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int DistributeCandies(int[] candyTypes)
    {
        var maxCount = candyTypes.Length / 2;

        var candyTypesDictionary = new Dictionary<int, int>();

        foreach (var candyType in candyTypes)
        {
            if (!candyTypesDictionary.TryAdd(candyType, 1))
            {
                candyTypesDictionary[candyType]++;
            }

            if (maxCount == candyTypesDictionary.Count)
            {
                return maxCount;
            }
        }

        return candyTypesDictionary.Count;
    }
}