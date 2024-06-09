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
public class SubarraySumsDivisibleByKArray : ISubarraySumsDivisibleByK
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

        var prefixMod = 0;

        var modGroups = new int[k];

        modGroups[0] = 1;

        foreach (var num in nums)
        {
            prefixMod = (prefixMod + (num % k) + k) % k;

            result += modGroups[prefixMod];

            modGroups[prefixMod]++;
        }

        return result;
    }
}