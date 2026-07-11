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

namespace LeetCode.Algorithms.IncrementSubmatricesByOne;

/// <inheritdoc />
public sealed class IncrementSubmatricesByOnePrefixSum : IIncrementSubmatricesByOne
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2 + q), where q is the number of queries
    ///     Space complexity - O(1), excluding the returned matrix
    /// </remarks>
    public int[][] RangeAddQueries(int n, int[][] queries)
    {
        var result = new int[n][];

        for (var i = 0; i < n; i++)
        {
            result[i] = new int[n];
        }

        var q = queries.Length;

        for (var i = 0; i < q; i++)
        {
            var query = queries[i];

            var row1 = query[0];
            var col1 = query[1];
            var row2 = query[2];
            var col2 = query[3];

            result[row1][col1] += 1;

            if (row2 + 1 < n)
            {
                result[row2 + 1][col1] -= 1;
            }

            if (col2 + 1 < n)
            {
                result[row1][col2 + 1] -= 1;
            }

            if (row2 + 1 < n && col2 + 1 < n)
            {
                result[row2 + 1][col2 + 1] += 1;
            }
        }

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                var top = i == 0 ? 0 : result[i - 1][j];
                var left = j == 0 ? 0 : result[i][j - 1];
                var topLeft = i == 0 || j == 0 ? 0 : result[i - 1][j - 1];

                result[i][j] += top + left - topLeft;
            }
        }

        return result;
    }
}