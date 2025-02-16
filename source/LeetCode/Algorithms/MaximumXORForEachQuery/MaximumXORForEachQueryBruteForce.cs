// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class MaximumXORForEachQueryBruteForce : IMaximumXORForEachQuery
{
    /// <summary>
    ///     Time complexity - O(n^2 + n * m)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="maximumBit"></param>
    /// <returns></returns>
    public int[] GetMaximumXor(int[] nums, int maximumBit)
    {
        var result = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            var xor = 0;

            for (var j = 0; j < nums.Length - i; j++)
            {
                xor ^= nums[j];
            }

            var maxXor = 0;

            for (var k = 0; k < Math.Pow(2, maximumBit); k++)
            {
                var currentXor = xor ^ k;

                if (currentXor < maxXor)
                {
                    continue;
                }

                result[i] = Math.Max(result[i], k);

                maxXor = currentXor;
            }
        }

        return result;
    }
}