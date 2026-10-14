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

namespace LeetCode.Algorithms.NumberOfGoodPairs;

/// <inheritdoc />
public sealed class NumberOfGoodPairsDictionary : INumberOfGoodPairs
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int NumIdenticalPairs(int[] nums)
    {
        var countDictionary = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (!countDictionary.TryAdd(num, 1))
            {
                countDictionary[num]++;
            }
        }

        var counts = new int[countDictionary.Count];

        countDictionary.Values.CopyTo(counts, 0);

        var result = 0;

        for (var i = 0; i < counts.Length; i++)
        {
            var count = counts[i];

            result += count * (count - 1) / 2;
        }

        return result;
    }
}