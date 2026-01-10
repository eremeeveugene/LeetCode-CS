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

namespace LeetCode.Algorithms.CountOfInterestingSubarrays;

/// <inheritdoc />
public sealed class CountOfInterestingSubarraysPrefixSum : ICountOfInterestingSubarrays
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(modulo)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="modulo"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public long CountInterestingSubarrays(IList<int> nums, int modulo, int k)
    {
        long result = 0;

        var prefixModDictionary = new Dictionary<int, int>
        {
            [0] = 1
        };

        var prefix = 0;

        foreach (var num in nums)
        {
            if (num % modulo == k)
            {
                prefix++;
            }

            var currentMod = prefix % modulo;
            var target = (currentMod - k + modulo) % modulo;

            if (prefixModDictionary.TryGetValue(target, out var count))
            {
                result += count;
            }

            if (!prefixModDictionary.TryAdd(currentMod, 1))
            {
                prefixModDictionary[currentMod]++;
            }
        }

        return result;
    }
}