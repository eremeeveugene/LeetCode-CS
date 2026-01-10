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

namespace LeetCode.Algorithms.LargestDivisibleSubset;

/// <inheritdoc />
public sealed class LargestDivisibleSubsetDynamicProgramming : ILargestDivisibleSubset
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public IList<int> LargestDivisibleSubset(int[] nums)
    {
        Array.Sort(nums);

        var dp = new int[nums.Length];
        var prev = new int[nums.Length];

        Array.Fill(dp, 1);
        Array.Fill(prev, -1);

        var maxIndex = 0;

        for (var i = 1; i < nums.Length; i++)
        {
            for (var j = 0; j < i; j++)
            {
                if (nums[i] % nums[j] == 0 && dp[j] + 1 > dp[i])
                {
                    dp[i] = dp[j] + 1;

                    prev[i] = j;
                }
            }

            if (dp[i] > dp[maxIndex])
            {
                maxIndex = i;
            }
        }

        var result = new List<int>();

        while (maxIndex != -1)
        {
            result.Add(nums[maxIndex]);

            maxIndex = prev[maxIndex];
        }

        result.Reverse();

        return result;
    }
}