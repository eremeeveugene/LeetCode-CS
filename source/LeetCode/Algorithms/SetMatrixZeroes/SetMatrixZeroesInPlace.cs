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
public sealed class SetMatrixZeroesInPlace : ISetMatrixZeroes
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </remarks>
    public void SetZeroes(int[][] matrix)
    {
        var firstRowHasZero = HasZeroInFirstRow(matrix);
        var firstColumnHasZero = HasZeroInFirstColumn(matrix);

        MarkZeroes(matrix);
        ApplyMarkers(matrix);

        if (firstColumnHasZero)
        {
            for (var i = 0; i < matrix.Length; i++)
            {
                matrix[i][0] = 0;
            }
        }

        if (firstRowHasZero)
        {
            for (var j = 0; j < matrix[0].Length; j++)
            {
                matrix[0][j] = 0;
            }
        }
    }

    private static bool HasZeroInFirstRow(int[][] matrix)
    {
        for (var j = 0; j < matrix[0].Length; j++)
        {
            if (matrix[0][j] == 0)
            {
                return true;
            }
        }

        return false;
    }

    private static bool HasZeroInFirstColumn(int[][] matrix)
    {
        for (var i = 0; i < matrix.Length; i++)
        {
            if (matrix[i][0] == 0)
            {
                return true;
            }
        }

        return false;
    }

    private static void MarkZeroes(int[][] matrix)
    {
        for (var i = 0; i < matrix.Length; i++)
        {
            for (var j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] != 0)
                {
                    continue;
                }

                matrix[i][0] = 0;
                matrix[0][j] = 0;
            }
        }
    }

    private static void ApplyMarkers(int[][] matrix)
    {
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
    }
}