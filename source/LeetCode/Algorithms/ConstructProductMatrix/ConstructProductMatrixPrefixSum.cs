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

namespace LeetCode.Algorithms.ConstructProductMatrix;

/// <inheritdoc />
public sealed class ConstructProductMatrixPrefixSum : IConstructProductMatrix
{
    private const int Modulo = 12_345;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int[][] ConstructProductMatrix(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        var result = new int[m][];

        for (var i = 0; i < m; i++)
        {
            result[i] = new int[n];
        }

        var prefix = 1;

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                result[i][j] = prefix;

                grid[i][j] %= Modulo;

                prefix = prefix * grid[i][j] % Modulo;
            }
        }

        var suffix = 1;

        for (var i = m - 1; i >= 0; i--)
        {
            for (var j = n - 1; j >= 0; j--)
            {
                result[i][j] = result[i][j] * suffix % Modulo;

                suffix = suffix * grid[i][j] % Modulo;
            }
        }

        return result;
    }
}