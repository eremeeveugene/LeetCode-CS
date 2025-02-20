// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class MaximumMatrixSumBruteForce : IMaximumMatrixSum
{
    public long MaxMatrixSum(int[][] matrix)
    {
        long sum = 0;
        var minAbsValue = int.MaxValue;
        var negativeCount = 0;

        foreach (var row in matrix)
        {
            foreach (var cell in row)
            {
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