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
public sealed class DistributeCandiesHashSet : IDistributeCandies
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="candyTypes"></param>
    /// <returns></returns>
    public int DistributeCandies(int[] candyTypes)
    {
        var maxCount = candyTypes.Length / 2;

        var candyTypesHashSet = new HashSet<int>();

        foreach (var candyType in candyTypes)
        {
            if (!candyTypesHashSet.Add(candyType))
            {
                continue;
            }

            if (maxCount == candyTypesHashSet.Count)
            {
                return maxCount;
            }
        }

        return candyTypesHashSet.Count;
    }
}