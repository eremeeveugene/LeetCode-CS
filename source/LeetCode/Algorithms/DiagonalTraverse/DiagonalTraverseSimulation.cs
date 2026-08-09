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

namespace LeetCode.Algorithms.DiagonalTraverse;

/// <inheritdoc />
public sealed class DiagonalTraverseSimulation : IDiagonalTraverse
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int[] FindDiagonalOrder(int[][] mat)
    {
        var m = mat.Length;
        var n = mat[0].Length;

        var result = new int[m * n];

        var row = 0;
        var column = 0;
        var direction = Direction.UpRight;

        for (var i = 0; i < result.Length; i++)
        {
            result[i] = mat[row][column];

            if (direction == Direction.UpRight)
            {
                if (column == n - 1)
                {
                    row++;
                    direction = Direction.DownLeft;
                }
                else if (row == 0)
                {
                    column++;
                    direction = Direction.DownLeft;
                }
                else
                {
                    row--;
                    column++;
                }
            }
            else if (row == m - 1)
            {
                column++;
                direction = Direction.UpRight;
            }
            else if (column == 0)
            {
                row++;
                direction = Direction.UpRight;
            }
            else
            {
                row++;
                column--;
            }
        }

        return result;
    }

    private enum Direction
    {
        UpRight,
        DownLeft
    }
}