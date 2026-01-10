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

namespace LeetCode.Algorithms.CountNumberOfBadPairs;

/// <inheritdoc />
public sealed class CountNumberOfBadPairsDictionary : ICountNumberOfBadPairs
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public long CountBadPairs(int[] nums)
    {
        long badPairsCount = 0;

        Dictionary<int, int> countDictionary = [];

        for (var i = 0; i < nums.Length; i++)
        {
            var difference = i - nums[i];

            if (countDictionary.TryGetValue(difference, out var goodPairsCount))
            {
                badPairsCount += i - goodPairsCount;

                countDictionary[difference]++;
            }
            else
            {
                badPairsCount += i;

                countDictionary[difference] = 1;
            }
        }

        return badPairsCount;
    }
}