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

namespace LeetCode.Algorithms.MinimumOperationsToMakeArrayElementsZero;

/// <inheritdoc />
public sealed class MinimumOperationsToMakeArrayElementsZeroPrefixSum : IMinimumOperationsToMakeArrayElementsZero
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log r), where n is the number of queries and r is the greatest right endpoint
    ///     Space complexity - O(1)
    /// </remarks>
    public long MinOperations(int[][] queries)
    {
        var n = queries.Length;

        long result = 0;

        for (var i = 0; i < n; i++)
        {
            var query = queries[i];

            var left = query[0];
            var right = query[1];

            var leftReductionCount = CountReductionsUpTo(left - 1);
            var rightReductionCount = CountReductionsUpTo(right);

            var reductionCount = rightReductionCount - leftReductionCount;
            var operationCount = (reductionCount + 1) / 2;

            result += operationCount;
        }

        return result;
    }

    /// <summary>
    ///     Counts the total number of divisions by four required to reduce every integer from one through <paramref name="right" /> to zero.
    /// </summary>
    /// <remarks>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </remarks>
    /// <param name="right">The inclusive upper bound.</param>
    /// <returns>The total number of required divisions.</returns>
    private static long CountReductionsUpTo(int right)
    {
        long result = 0;

        long left = 1;

        while (left <= right)
        {
            result += right - left + 1;

            left *= 4;
        }

        return result;
    }
}