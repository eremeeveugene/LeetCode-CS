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

namespace LeetCode.Algorithms.SpecialPositionsInBinaryMatrix;

/// <inheritdoc />
public sealed class SpecialPositionsInBinaryMatrixSum : ISpecialPositionsInBinaryMatrix
{
    /// <summary>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m + n)
    /// </summary>
    /// <param name="mat"></param>
    /// <returns></returns>
    public int NumSpecial(int[][] mat)
    {
        var m = mat.Length;
        var n = mat[0].Length;

        Span<int> rowsSum = stackalloc int[m];
        Span<int> columnsSum = stackalloc int[n];

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                var cell = mat[i][j];

                rowsSum[i] += cell;
                columnsSum[j] += cell;
            }
        }

        var result = 0;

        for (var i = 0; i < m; i++)
        {
            if (rowsSum[i] != 1)
            {
                continue;
            }

            for (var j = 0; j < n; j++)
            {
                if (mat[i][j] != 1 || columnsSum[j] != 1)
                {
                    continue;
                }

                result++;

                break;
            }
        }

        return result;
    }
}