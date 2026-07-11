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

namespace LeetCode.Algorithms.ConcatenateNonZeroDigitsAndMultiplyBySum2;

/// <inheritdoc />
public sealed class ConcatenateNonZeroDigitsAndMultiplyBySum2PrefixSum : IConcatenateNonZeroDigitsAndMultiplyBySum2
{
    private const int Modulo = 1_000_000_007;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + q), where n is the length of s and q is the number of queries
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] SumAndMultiply(string s, int[][] queries)
    {
        var n = s.Length;

        var values = new long[n + 1];
        var counts = new int[n + 1];
        var sums = new long[n + 1];
        var pow10 = new long[n + 1];

        pow10[0] = 1;

        for (var i = 0; i < n; i++)
        {
            pow10[i + 1] = pow10[i] * 10 % Modulo;

            var digit = s[i] - '0';

            if (digit == 0)
            {
                values[i + 1] = values[i];
                counts[i + 1] = counts[i];
                sums[i + 1] = sums[i];
            }
            else
            {
                values[i + 1] = ((values[i] * 10) + digit) % Modulo;
                counts[i + 1] = counts[i] + 1;
                sums[i + 1] = sums[i] + digit;
            }
        }

        var q = queries.Length;

        var result = new int[q];

        for (var i = 0; i < q; i++)
        {
            var query = queries[i];

            var left = query[0];
            var right = query[1];

            var k = counts[right + 1] - counts[left];

            var value = (values[right + 1] - (values[left] * pow10[k])) % Modulo;

            if (value < 0)
            {
                value += Modulo;
            }

            var sum = sums[right + 1] - sums[left];

            result[i] = (int)(value * sum % Modulo);
        }

        return result;
    }
}