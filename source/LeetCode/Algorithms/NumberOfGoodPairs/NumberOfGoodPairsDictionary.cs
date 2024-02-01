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

namespace LeetCode.Algorithms.NumberOfGoodPairs;

/// <inheritdoc />
public class NumberOfGoodPairsDictionary : INumberOfGoodPairs
{
    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int NumIdenticalPairs(int[] nums)
    {
        var countDictionary = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (!countDictionary.TryAdd(num, 1))
            {
                countDictionary[num]++;
            }
        }

        return countDictionary.Select(pair => pair.Value).Select(count => count * (count - 1) / 2).Sum();
    }
}