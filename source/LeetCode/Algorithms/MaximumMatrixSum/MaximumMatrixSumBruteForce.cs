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

namespace LeetCode.Algorithms.MaximumMatrixSum;

/// <inheritdoc />
public sealed class MaximumMatrixSumBruteForce : IMaximumMatrixSum
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    public long MaxMatrixSum(int[][] matrix)
    {
        long sum = 0;
        var minAbsValue = int.MaxValue;
        var negativeCount = 0;

        for (var i = 0; i < matrix.Length; i++)
        {
            var row = matrix[i];

            for (var j = 0; j < row.Length; j++)
            {
                var cell = row[j];

                sum += Math.Abs(cell);

                if (cell < 0)
                {
                    negativeCount++;
                }

                minAbsValue = Math.Min(minAbsValue, Math.Abs(cell));
            }
        }

        if (negativeCount % 2 != 0)
        {
            sum -= 2 * minAbsValue;
        }

        return sum;
    }
}