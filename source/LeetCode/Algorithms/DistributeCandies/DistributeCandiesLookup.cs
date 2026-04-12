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
public sealed class DistributeCandiesLookup : IDistributeCandies
{
    private const int MinCandyType = -100_000;
    private const int MaxCandyType = 100_000;
    private const int Offset = -MinCandyType;
    private const int LookupSize = MaxCandyType - MinCandyType + 1;

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="candyTypes"></param>
    /// <returns></returns>
    public int DistributeCandies(int[] candyTypes)
    {
        var maxCount = candyTypes.Length / 2;

        var candyTypesLookup = new bool[LookupSize];

        var uniqueCount = 0;

        foreach (var candyType in candyTypes)
        {
            var index = GetIndex(candyType);

            if (candyTypesLookup[index])
            {
                continue;
            }

            candyTypesLookup[index] = true;

            uniqueCount++;

            if (uniqueCount == maxCount)
            {
                return maxCount;
            }
        }

        return uniqueCount;
    }

    private static int GetIndex(int candyType)
    {
        return candyType + Offset;
    }
}