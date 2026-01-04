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
public class CountSquareSubmatricesWithAllOnesDynamicProgramming : ICountSquareSubmatricesWithAllOnes
{
    /// <summary>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
    public int CountSquares(int[][] matrix)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;

        var count = 0;

        for (var i = 0; i < m; i++)
        {
            count += matrix[i][0];
        }

        for (var j = 1; j < n; j++)
        {
            count += matrix[0][j];
        }

        for (var i = 1; i < m; i++)
        {
            for (var j = 1; j < n; j++)
            {
                if (matrix[i][j] != 1)
                {
                    continue;
                }

                matrix[i][j] = Math.Min(matrix[i - 1][j - 1], Math.Min(matrix[i - 1][j], matrix[i][j - 1])) + 1;

                count += matrix[i][j];
            }
        }

        return count;
    }
}