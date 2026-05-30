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
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public int FindLucky(int[] arr)
    {
        var frequencyDictionary = new Dictionary<int, int>();

        foreach (var number in arr)
        {
            if (!frequencyDictionary.TryAdd(number, 1))
            {
                frequencyDictionary[number]++;
            }
        }

        var result = -1;

        foreach (var frequency in frequencyDictionary.Where(frequency => frequency.Key == frequency.Value && frequency.Key > result))
        {
            result = frequency.Key;
        }

        return result;
    }
}