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

namespace LeetCode.Algorithms.ModifyTheMatrix;

/// <inheritdoc />
public sealed class ModifyTheMatrixIterative : IModifyTheMatrix
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m * n)
    /// </remarks>
    public int[][] ModifiedMatrix(int[][] matrix)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;

        for (var j = 0; j < n; j++)
        {
            var max = 0;

            for (var i = 0; i < m; i++)
            {
                max = Math.Max(max, matrix[i][j]);
            }

            for (var i = 0; i < m; i++)
            {
                if (matrix[i][j] == -1)
                {
                    matrix[i][j] = max;
                }
            }
        }

        return matrix;
    }
}