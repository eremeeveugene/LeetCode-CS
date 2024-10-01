// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class CheckIfArrayPairsAreDivisibleByKDictionary : ICheckIfArrayPairsAreDivisibleByK
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public bool CanArrange(int[] arr, int k)
    {
        var countDictionary = new Dictionary<int, int>();

        foreach (var item in arr)
        {
            var remainder = ((item % k) + k) % k;

            if (!countDictionary.TryAdd(remainder, 1))
            {
                countDictionary[remainder]++;
            }
        }

        foreach (var keyValuePair in countDictionary)
        {
            if (keyValuePair.Key == 0)
            {
                if (keyValuePair.Value % 2 != 0)
                {
                    return false;
                }
            }
            else
            {
                if (countDictionary.TryGetValue(k - keyValuePair.Key, out var count) && count == keyValuePair.Value)
                {
                    continue;
                }

                return false;
            }
        }

        return true;
    }
}