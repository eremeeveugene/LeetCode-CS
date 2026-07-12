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

namespace LeetCode.Algorithms.SubarraySumsDivisibleByK;

/// <inheritdoc />
public sealed class SubarraySumsDivisibleByKArray : ISubarraySumsDivisibleByK
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(k)
    /// </remarks>
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