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

namespace LeetCode.Algorithms.CountElementsWithMaximumFrequency;

/// <inheritdoc />
public class CountElementsWithMaximumFrequencyDictionaryLinq : ICountElementsWithMaximumFrequency
{
    /// <summary>
    ///     Time complexity - O(n + 2m) where m is the number of unique elements. Simplifies to O(n)
    ///     Space complexity - O(m), where m is the number of unique elements
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MaxFrequencyElements(int[] nums)
    {
        var numsDictionary = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (!numsDictionary.TryAdd(num, 1))
            {
                numsDictionary[num]++;
            }
        }

        var maxFrequency = numsDictionary.Max(num => num.Value);

        return numsDictionary.Where(num => num.Value == maxFrequency).Sum(num => num.Value);
    }
}