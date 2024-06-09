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

namespace LeetCode.Algorithms.SubarraySumsDivisibleByK;

/// <inheritdoc />
public class SubarraySumsDivisibleByKDictionary : ISubarraySumsDivisibleByK
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(k)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int SubarraysDivByK(int[] nums, int k)
    {
        var result = 0;

        var prefixModDictionary = new Dictionary<int, int> { { 0, 1 } };

        var sum = 0;

        foreach (var num in nums)
        {
            sum += num;

            var prefixMod = sum % k;

            if (prefixMod < 0)
            {
                prefixMod += k;
            }

            if (prefixModDictionary.TryAdd(prefixMod, 1))
            {
                continue;
            }

            result += prefixModDictionary[prefixMod];

            prefixModDictionary[prefixMod]++;
        }

        return result;
    }
}