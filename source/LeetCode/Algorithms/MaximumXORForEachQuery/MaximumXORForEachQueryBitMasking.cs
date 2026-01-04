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

namespace LeetCode.Algorithms.MaximumXORForEachQuery;

/// <inheritdoc />
public class MaximumXORForEachQueryBitMasking : IMaximumXORForEachQuery
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="maximumBit"></param>
    /// <returns></returns>
    public int[] GetMaximumXor(int[] nums, int maximumBit)
    {
        var result = new int[nums.Length];

        var xor = nums.Aggregate(0, (current, num) => current ^ num);

        var mask = (1 << maximumBit) - 1;

        for (var i = 0; i < nums.Length; i++)
        {
            result[i] = xor ^ mask;

            xor ^= nums[nums.Length - 1 - i];
        }

        return result;
    }
}