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

namespace LeetCode.Algorithms.FindLuckyIntegerInAnArray;

/// <inheritdoc />
public sealed class FindLuckyIntegerInAnArrayFrequencyDictionary : IFindLuckyIntegerInAnArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int FindLucky(int[] arr)
    {
        var numToFrequencyDictionary = new Dictionary<int, int>();

        for (var i = 0; i < arr.Length; i++)
        {
            var num = arr[i];

            if (!numToFrequencyDictionary.TryAdd(num, 1))
            {
                numToFrequencyDictionary[num]++;
            }
        }

        var result = -1;

        foreach (var numToFrequency in numToFrequencyDictionary)
        {
            if (numToFrequency.Key == numToFrequency.Value && numToFrequency.Key > result)
            {
                result = numToFrequency.Key;
            }
        }

        return result;
    }
}