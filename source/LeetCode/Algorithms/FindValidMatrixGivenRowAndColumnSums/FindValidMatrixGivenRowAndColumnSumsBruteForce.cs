// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.FindValidMatrixGivenRowAndColumnSums;

/// <inheritdoc />
public class FindValidMatrixGivenRowAndColumnSumsBruteForce : IFindValidMatrixGivenRowAndColumnSums
{
    /// <summary>
    ///     Time complexity - O(m^2 * n)
    ///     Space complexity - O(m * n)
    /// </summary>
    /// <param name="rowSum"></param>
    /// <param name="colSum"></param>
    /// <returns></returns>
    public int[][] RestoreMatrix(int[] rowSum, int[] colSum)
    {
        var result = new int[rowSum.Length][];

        for (var i = 0; i < result.Length; i++)
        {
            result[i] = new int[colSum.Length];

            var currentRowSum = 0;

            for (var j = 0; j < result[i].Length; j++)
            {
                var currentColSum = colSum[j];

                for (var k = 0; k < i; k++)
                {
                    currentColSum -= result[k][j];
                }

                var sum = Math.Min(currentColSum, rowSum[i] - currentRowSum);

                result[i][j] = sum;

                currentRowSum += sum;

                if (currentRowSum >= rowSum[i])
                {
                    break;
                }
            }
        }

        return result;
    }
}