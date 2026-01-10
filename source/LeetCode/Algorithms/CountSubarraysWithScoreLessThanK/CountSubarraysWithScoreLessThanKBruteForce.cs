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

namespace LeetCode.Algorithms.CountSubarraysWithScoreLessThanK;

/// <inheritdoc />
public sealed class CountSubarraysWithScoreLessThanKBruteForce : ICountSubarraysWithScoreLessThanK
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public long CountSubarrays(int[] nums, long k)
    {
        long result = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            long sum = 0;

            for (var j = i; j < nums.Length; j++)
            {
                sum += nums[j];

                var length = j - i + 1;

                if (sum * length < k)
                {
                    result++;
                }
                else
                {
                    break;
                }
            }
        }

        return result;
    }
}