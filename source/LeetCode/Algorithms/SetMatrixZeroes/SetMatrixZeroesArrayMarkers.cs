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

namespace LeetCode.Algorithms.SetMatrixZeroes;

/// <inheritdoc />
public class SetMatrixZeroesArrayMarkers : ISetMatrixZeroes
{
    /// <summary>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m + n)
    /// </summary>
    /// <param name="matrix"></param>
    public void SetZeroes(int[][] matrix)
    {
        var rows = new bool[matrix.Length];
        var columns = new bool[matrix[0].Length];

        for (var i = 0; i < matrix.Length; i++)
        {
            for (var j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] != 0)
                {
                    continue;
                }

                rows[i] = true;
                columns[j] = true;
            }
        }

        for (var i = 0; i < rows.Length; i++)
        {
            if (!rows[i])
            {
                continue;
            }

            for (var j = 0; j < columns.Length; j++)
            {
                matrix[i][j] = 0;
            }
        }

        for (var i = 0; i < columns.Length; i++)
        {
            if (!columns[i])
            {
                continue;
            }

            for (var j = 0; j < rows.Length; j++)
            {
                matrix[j][i] = 0;
            }
        }
    }
}