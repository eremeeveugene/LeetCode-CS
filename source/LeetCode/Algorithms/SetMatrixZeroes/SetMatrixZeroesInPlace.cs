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

namespace LeetCode.Algorithms.SetMatrixZeroes;

/// <inheritdoc />
public class SetMatrixZeroesInPlace : ISetMatrixZeroes
{
    /// <summary>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="matrix"></param>
    public void SetZeroes(int[][] matrix)
    {
        var firstRowZero = false;
        var firstColZero = false;

        for (var i = 0; i < matrix.Length; i++)
        {
            for (var j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] != 0)
                {
                    continue;
                }

                if (i == 0)
                {
                    firstRowZero = true;
                }

                if (j == 0)
                {
                    firstColZero = true;
                }

                matrix[i][0] = 0;
                matrix[0][j] = 0;
            }
        }

        for (var i = 1; i < matrix.Length; i++)
        {
            for (var j = 1; j < matrix[i].Length; j++)
            {
                if (matrix[i][0] == 0 || matrix[0][j] == 0)
                {
                    matrix[i][j] = 0;
                }
            }
        }

        if (firstColZero)
        {
            foreach (var row in matrix)
            {
                row[0] = 0;
            }
        }

        if (firstRowZero)
        {
            for (var j = 0; j < matrix[0].Length; j++)
            {
                matrix[0][j] = 0;
            }
        }
    }
}