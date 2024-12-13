// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class SpiralMatrixSimulation : ISpiralMatrix
{
    /// <summary>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(n * m)
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
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
            for (var j = left; j <= right; j++)
            {
                spiralMatrix[spiralMatrixIndex] = matrix[top][j];

                spiralMatrixIndex++;
            }

            top++;

            for (var i = top; i <= bottom; i++)
            {
                spiralMatrix[spiralMatrixIndex] = matrix[i][right];

                spiralMatrixIndex++;
            }

            right--;

            if (top <= bottom)
            {
                for (var j = right; j >= left; j--)
                {
                    spiralMatrix[spiralMatrixIndex] = matrix[bottom][j];

                    spiralMatrixIndex++;
                }

                bottom--;
            }

            if (left <= right)
            {
                for (var i = bottom; i >= top; i--)
                {
                    spiralMatrix[spiralMatrixIndex] = matrix[i][left];

                    spiralMatrixIndex++;
                }

                left++;
            }
        }

        return spiralMatrix;
    }
}