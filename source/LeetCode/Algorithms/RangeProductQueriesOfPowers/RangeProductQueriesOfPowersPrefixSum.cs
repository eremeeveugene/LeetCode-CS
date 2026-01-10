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

using System.Numerics;

namespace LeetCode.Algorithms.RangeProductQueriesOfPowers;

/// <inheritdoc />
public sealed class RangeProductQueriesOfPowersPrefixSum : IRangeProductQueriesOfPowers
{
    private const int Mod = 1_000_000_007;

    /// <summary>
    ///     Time complexity - O(q), where q is queries.Length
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <param name="queries"></param>
    /// <returns></returns>
    public int[] ProductQueries(int n, int[][] queries)
    {
        var exponents = new List<int>(BitOperations.PopCount((uint)n));

        for (var bit = 0; bit < 31; bit++)
        {
            if (((n >> bit) & 1) == 0)
            {
                continue;
            }

            exponents.Add(bit);
        }

        var exponentsPrefixSum = new int[exponents.Count + 1];

        for (var i = 0; i < exponents.Count; i++)
        {
            exponentsPrefixSum[i + 1] = exponentsPrefixSum[i] + exponents[i];
        }

        var maxExponent = exponentsPrefixSum[^1];

        var powersOfTwo = new int[maxExponent + 1];

        powersOfTwo[0] = 1;

        for (var i = 1; i <= maxExponent; i++)
        {
            powersOfTwo[i] = powersOfTwo[i - 1] * 2 % Mod;
        }

        var result = new int[queries.Length];

        for (var i = 0; i < queries.Length; i++)
        {
            var left = queries[i][0];
            var right = queries[i][1];
            var exponent = exponentsPrefixSum[right + 1] - exponentsPrefixSum[left];

            result[i] = powersOfTwo[exponent];
        }

        return result;
    }
}