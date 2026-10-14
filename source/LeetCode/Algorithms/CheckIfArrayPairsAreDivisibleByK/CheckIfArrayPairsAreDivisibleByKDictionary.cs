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

namespace LeetCode.Algorithms.CheckIfArrayPairsAreDivisibleByK;

/// <inheritdoc />
public sealed class CheckIfArrayPairsAreDivisibleByKDictionary : ICheckIfArrayPairsAreDivisibleByK
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public bool CanArrange(int[] arr, int k)
    {
        var countDictionary = new Dictionary<int, int>();

        for (var i = 0; i < arr.Length; i++)
        {
            var item = arr[i];

            var remainder = ((item % k) + k) % k;

            if (!countDictionary.TryAdd(remainder, 1))
            {
                countDictionary[remainder]++;
            }
        }

        var remainders = new int[countDictionary.Count];

        countDictionary.Keys.CopyTo(remainders, 0);

        for (var i = 0; i < remainders.Length; i++)
        {
            var remainder = remainders[i];
            var remainderCount = countDictionary[remainder];

            if (remainder == 0)
            {
                if (remainderCount % 2 != 0)
                {
                    return false;
                }
            }
            else
            {
                if (countDictionary.TryGetValue(k - remainder, out var count) && count == remainderCount)
                {
                    continue;
                }

                return false;
            }
        }

        return true;
    }
}