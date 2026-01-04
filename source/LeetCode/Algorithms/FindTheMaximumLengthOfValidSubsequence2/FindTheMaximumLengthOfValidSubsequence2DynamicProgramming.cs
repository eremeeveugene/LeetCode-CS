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

namespace LeetCode.Algorithms.FindTheMaximumLengthOfValidSubsequence2;

/// <inheritdoc />
public class FindTheMaximumLengthOfValidSubsequence2DynamicProgramming : IFindTheMaximumLengthOfValidSubsequence2
{
    /// <summary>
    ///     Time complexity - O(k^2 + n * k)
    ///     Space complexity - O(k^2)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int MaximumLength(int[] nums, int k)
    {
        var maximumLength = 0;

        var dp = new int[k, k];

        foreach (var num in nums)
        {
            var mod = num % k;

            for (var prev = 0; prev < k; prev++)
            {
                dp[prev, mod] = dp[mod, prev] + 1;

                maximumLength = Math.Max(maximumLength, dp[prev, mod]);
            }
        }

        return maximumLength;
    }
}