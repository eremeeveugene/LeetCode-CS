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
public class CountElementsWithMaximumFrequencyDictionary : ICountElementsWithMaximumFrequency
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(m), where m is the number of unique elements
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MaxFrequencyElements(int[] nums)
    {
        var numsDictionary = new Dictionary<int, int>();
        var maxFrequency = 0;
        var maxFrequencySum = 0;

        foreach (var num in nums)
        {
            if (!numsDictionary.TryAdd(num, 1))
            {
                numsDictionary[num]++;
            }

            if (numsDictionary[num] > maxFrequency)
            {
                maxFrequency = numsDictionary[num];
                maxFrequencySum = numsDictionary[num];
            }
            else if (numsDictionary[num] == maxFrequency)
            {
                maxFrequencySum += numsDictionary[num];
            }
        }

        return maxFrequencySum;
    }
}