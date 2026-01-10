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

namespace LeetCode.Algorithms.LongestHarmoniousSubsequence;

/// <inheritdoc />
public sealed class LongestHarmoniousSubsequenceDictionary : ILongestHarmoniousSubsequence
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int FindLHS(int[] nums)
    {
        var frequencyDictionary = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (frequencyDictionary.TryAdd(num, 1))
            {
                continue;
            }

            frequencyDictionary[num]++;
        }

        var maxLength = 0;

        foreach (var frequency in frequencyDictionary)
        {
            if (!frequencyDictionary.ContainsKey(frequency.Key + 1))
            {
                continue;
            }

            var length = frequency.Value + frequencyDictionary[frequency.Key + 1];

            if (length > maxLength)
            {
                maxLength = length;
            }
        }

        return maxLength;
    }
}