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

namespace LeetCode.Algorithms.CountLargestGroup;

/// <inheritdoc />
public sealed class CountLargestGroupFrequencyDictionary : ICountLargestGroup
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </remarks>
    public int CountLargestGroup(int n)
    {
        var count = 0;
        var max = 0;

        var frequencyDictionary = new Dictionary<int, int>();

        for (var i = 1; i <= n; i++)
        {
            var sum = 0;

            var num = i;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            if (!frequencyDictionary.TryAdd(sum, 1))
            {
                frequencyDictionary[sum]++;
            }

            if (frequencyDictionary[sum] > max)
            {
                max = frequencyDictionary[sum];

                count = 1;
            }
            else if (frequencyDictionary[sum] == max)
            {
                count++;
            }
        }

        return count;
    }
}