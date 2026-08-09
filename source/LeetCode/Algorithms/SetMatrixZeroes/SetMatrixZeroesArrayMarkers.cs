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
public sealed class SetMatrixZeroesArrayMarkers : ISetMatrixZeroes
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m + n)
    /// </remarks>
    public void SetZeroes(int[][] matrix)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;

        var rows = new bool[m];
        var columns = new bool[n];

        MarkZeroes(matrix, rows, columns);

        for (var i = 0; i < m; i++)
        {
            if (!rows[i])
            {
                continue;
            }

            for (var j = 0; j < n; j++)
            {
                matrix[i][j] = 0;
            }
        }

        for (var i = 0; i < n; i++)
        {
            if (!columns[i])
            {
                continue;
            }

            for (var j = 0; j < m; j++)
            {
                matrix[j][i] = 0;
            }
        }
    }

    private static void MarkZeroes(int[][] matrix, bool[] rows, bool[] columns)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (matrix[i][j] != 0)
                {
                    continue;
                }

                rows[i] = true;
                columns[j] = true;
            }
        }
    }
}