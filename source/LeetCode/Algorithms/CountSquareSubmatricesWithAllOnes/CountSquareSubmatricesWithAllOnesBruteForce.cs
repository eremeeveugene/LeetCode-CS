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

namespace LeetCode.Algorithms.CountSquareSubmatricesWithAllOnes;

/// <inheritdoc />
public sealed class CountSquareSubmatricesWithAllOnesBruteForce : ICountSquareSubmatricesWithAllOnes
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n * min(m, n)^2)
    ///     Space complexity - O(1)
    /// </remarks>
    public int CountSquares(int[][] matrix)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;

        var sideLength = Math.Min(m, n);

        var count = 0;

        for (var k = 1; k <= sideLength; k++)
        {
            var targetSum = k * k;

            for (var i = 0; i <= m - k; i++)
            {
                for (var j = 0; j <= n - k; j++)
                {
                    var squareSum = GetSquareSum(matrix, i, j, k);

                    if (squareSum == targetSum)
                    {
                        count++;
                    }
                }
            }
        }

        return count;
    }

    private static int GetSquareSum(int[][] matrix, int row, int column, int sideLength)
    {
        var squareSum = 0;

        for (var i = row; i < row + sideLength; i++)
        {
            for (var j = column; j < column + sideLength; j++)
            {
                squareSum += matrix[i][j];
            }
        }

        return squareSum;
    }
}