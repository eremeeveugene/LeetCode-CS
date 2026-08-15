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

namespace LeetCode.Algorithms.SpiralMatrix;

/// <inheritdoc />
public sealed class SpiralMatrixSimulation : ISpiralMatrix
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(n * m)
    /// </remarks>
    public IList<int> SpiralOrder(int[][] matrix)
    {
        var rows = matrix.Length;
        var columns = matrix[0].Length;

        var spiralMatrix = new int[rows * columns];
        var spiralMatrixIndex = 0;

        var left = 0;
        var top = 0;
        var right = columns - 1;
        var bottom = rows - 1;

        while (top <= bottom && left <= right)
        {
            spiralMatrixIndex = AppendTopRow(matrix, spiralMatrix, spiralMatrixIndex, top, left, right);

            top++;

            spiralMatrixIndex = AppendRightColumn(matrix, spiralMatrix, spiralMatrixIndex, right, top, bottom);

            right--;

            if (top <= bottom)
            {
                spiralMatrixIndex = AppendBottomRow(matrix, spiralMatrix, spiralMatrixIndex, bottom, right, left);

                bottom--;
            }

            if (left > right)
            {
                continue;
            }

            spiralMatrixIndex = AppendLeftColumn(matrix, spiralMatrix, spiralMatrixIndex, left, bottom, top);

            left++;
        }

        return spiralMatrix;
    }

    private static int AppendTopRow(int[][] matrix, int[] spiralMatrix, int spiralMatrixIndex, int row, int left, int right)
    {
        for (var j = left; j <= right; j++)
        {
            spiralMatrix[spiralMatrixIndex] = matrix[row][j];

            spiralMatrixIndex++;
        }

        return spiralMatrixIndex;
    }

    private static int AppendRightColumn(int[][] matrix, int[] spiralMatrix, int spiralMatrixIndex, int column, int top, int bottom)
    {
        for (var i = top; i <= bottom; i++)
        {
            spiralMatrix[spiralMatrixIndex] = matrix[i][column];

            spiralMatrixIndex++;
        }

        return spiralMatrixIndex;
    }

    private static int AppendBottomRow(int[][] matrix, int[] spiralMatrix, int spiralMatrixIndex, int row, int right, int left)
    {
        for (var j = right; j >= left; j--)
        {
            spiralMatrix[spiralMatrixIndex] = matrix[row][j];

            spiralMatrixIndex++;
        }

        return spiralMatrixIndex;
    }

    private static int AppendLeftColumn(int[][] matrix, int[] spiralMatrix, int spiralMatrixIndex, int column, int bottom, int top)
    {
        for (var i = bottom; i >= top; i--)
        {
            spiralMatrix[spiralMatrixIndex] = matrix[i][column];

            spiralMatrixIndex++;
        }

        return spiralMatrixIndex;
    }
}