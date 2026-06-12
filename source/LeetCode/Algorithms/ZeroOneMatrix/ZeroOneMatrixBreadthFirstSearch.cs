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
public sealed class ZeroOneMatrixBreadthFirstSearch : IZeroOneMatrix
{
    private static readonly (int Row, int Col)[] Directions = [(1, 0), (-1, 0), (0, 1), (0, -1)];

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m * n)
    /// </remarks>
    public int[][] UpdateMatrix(int[][] mat)
    {
        var m = mat.Length;
        var n = mat[0].Length;

        var queue = new Queue<(int Row, int Col)>();

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (mat[i][j] == 0)
                {
                    queue.Enqueue((i, j));
                }
                else
                {
                    mat[i][j] = -1;
                }
            }
        }

        while (queue.Count > 0)
        {
            var (row, col) = queue.Dequeue();

            foreach (var direction in Directions)
            {
                var nextRow = row + direction.Row;
                var nextCol = col + direction.Col;

                if (nextRow < 0 || nextCol < 0 || nextRow >= m || nextCol >= n || mat[nextRow][nextCol] != -1)
                {
                    continue;
                }

                mat[nextRow][nextCol] = mat[row][col] + 1;

                queue.Enqueue((nextRow, nextCol));
            }
        }

        return mat;
    }
}