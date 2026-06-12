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

namespace LeetCode.Algorithms.ZeroOneMatrix;

/// <inheritdoc />
public sealed class ZeroOneMatrixDynamicProgramming : IZeroOneMatrix
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int[][] UpdateMatrix(int[][] mat)
    {
        var m = mat.Length;
        var n = mat[0].Length;

        var infinity = m + n;

        for (var row = 0; row < m; row++)
        {
            for (var col = 0; col < n; col++)
            {
                if (mat[row][col] == 0)
                {
                    continue;
                }

                var up = row > 0 ? mat[row - 1][col] : infinity;
                var left = col > 0 ? mat[row][col - 1] : infinity;

                mat[row][col] = int.Min(up, left) + 1;
            }
        }

        for (var row = m - 1; row >= 0; row--)
        {
            for (var col = n - 1; col >= 0; col--)
            {
                if (mat[row][col] == 0)
                {
                    continue;
                }

                var down = row < m - 1 ? mat[row + 1][col] : infinity;
                var right = col < n - 1 ? mat[row][col + 1] : infinity;

                mat[row][col] = int.Min(mat[row][col], int.Min(down, right) + 1);
            }
        }

        return mat;
    }
}