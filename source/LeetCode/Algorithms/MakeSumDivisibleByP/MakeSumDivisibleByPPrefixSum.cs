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

namespace LeetCode.Algorithms.MakeSumDivisibleByP;

/// <inheritdoc />
public class MakeSumDivisibleByPPrefixSum : IMakeSumDivisibleByP
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="p"></param>
    /// <returns></returns>
    public int MinSubarray(int[] nums, int p)
    {
        var sum = nums.Aggregate<int, long>(0, (current, num) => current + num);

        var target = (int)(sum % p);

        if (target == 0)
        {
            return 0;
        }

        var prefixModDictionary = new Dictionary<int, int> { [0] = -1 };

        var result = nums.Length;
        var currentMod = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            currentMod = (currentMod + nums[i]) % p;

            var complement = (currentMod - target + p) % p;

            if (prefixModDictionary.TryGetValue(complement, out var value))
            {
                result = Math.Min(result, i - value);
            }

            prefixModDictionary[currentMod] = i;
        }

        return result == nums.Length ? -1 : result;
    }
}