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
    /// <summary>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="mat"></param>
    /// <returns></returns>
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

            switch (direction)
            {
                case Direction.UpRight when column == n - 1:
                    row++;
                    direction = Direction.DownLeft;
                    break;
                case Direction.UpRight when row == 0:
                    column++;
                    direction = Direction.DownLeft;
                    break;
                case Direction.UpRight:
                    row--;
                    column++;
                    break;
                case Direction.DownLeft when row == m - 1:
                    column++;
                    direction = Direction.UpRight;
                    break;
                case Direction.DownLeft when column == 0:
                    row++;
                    direction = Direction.UpRight;
                    break;
                case Direction.DownLeft:
                    row++;
                    column--;
                    break;
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