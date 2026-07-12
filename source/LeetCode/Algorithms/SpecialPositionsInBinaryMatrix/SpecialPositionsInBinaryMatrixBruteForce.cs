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
public sealed class SpecialPositionsInBinaryMatrixBruteForce : ISpecialPositionsInBinaryMatrix
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n * (m + n))
    ///     Space complexity - O(1)
    /// </remarks>
    public int NumSpecial(int[][] mat)
    {
        var result = 0;

        var m = mat.Length;
        var n = mat[0].Length;

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (IsSpecial(mat, i, j, m, n))
                {
                    result++;
                }
            }
        }

        return result;
    }

    private static bool IsSpecial(int[][] mat, int i, int j, int m, int n)
    {
        if (mat[i][j] != 1)
        {
            return false;
        }

        for (var c = 0; c < n; c++)
        {
            if (c == j)
            {
                continue;
            }

            if (mat[i][c] == 1)
            {
                return false;
            }
        }

        for (var r = 0; r < m; r++)
        {
            if (r == i)
            {
                continue;
            }

            if (mat[r][j] == 1)
            {
                return false;
            }
        }

        return true;
    }
}