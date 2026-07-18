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

namespace LeetCode.Algorithms.XorAfterRangeMultiplicationQueries1;

/// <inheritdoc />
public sealed class XorAfterRangeMultiplicationQueries1Simulation : IXorAfterRangeMultiplicationQueries1
{
    private const int Modulo = 1_000_000_007;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int XorAfterQueries(int[] nums, int[][] queries)
    {
        var m = queries.Length;

        for (var i = 0; i < m; i++)
        {
            var query = queries[i];

            var left = query[0];
            var right = query[1];
            var step = query[2];
            var value = query[3];

            for (var index = left; index <= right; index += step)
            {
                var num = nums[index];

                nums[index] = (int)(num * (long)value % Modulo);
            }
        }

        var n = nums.Length;

        var result = 0;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            result ^= num;
        }

        return result;
    }
}