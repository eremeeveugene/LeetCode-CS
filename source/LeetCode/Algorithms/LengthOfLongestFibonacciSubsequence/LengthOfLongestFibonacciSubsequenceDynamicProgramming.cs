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

namespace LeetCode.Algorithms.LengthOfLongestFibonacciSubsequence;

/// <inheritdoc />
public sealed class LengthOfLongestFibonacciSubsequenceDynamicProgramming : ILengthOfLongestFibonacciSubsequence
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n^2)
    /// </remarks>
    public int LenLongestFibSubseq(int[] arr)
    {
        var dictionary = new Dictionary<int, int>();

        for (var i = 0; i < arr.Length; i++)
        {
            dictionary[arr[i]] = i;
        }

        var dp = new int[arr.Length, arr.Length];

        var result = 0;

        for (var i = 0; i < arr.Length; i++)
        {
            for (var j = i + 1; j < arr.Length; j++)
            {
                dp[i, j] = 2;

                var potentialPrev = arr[j] - arr[i];

                if (!dictionary.TryGetValue(potentialPrev, out var k) || k >= i)
                {
                    continue;
                }

                dp[i, j] = dp[k, i] + 1;

                result = Math.Max(result, dp[i, j]);
            }
        }

        return result >= 3 ? result : 0;
    }
}