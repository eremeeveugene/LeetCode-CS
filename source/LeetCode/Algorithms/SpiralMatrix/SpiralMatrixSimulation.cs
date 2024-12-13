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
        var spiralMatrix = new List<int>(matrix.Length);

        var rows = matrix.Length;
        var cols = matrix[0].Length;

        var top = 0;
        var left = 0;
        var bottom = rows - 1;
        var right = cols - 1;

        while (top <= bottom && left <= right)
        {
            for (var j = left; j <= right; j++)
            {
                spiralMatrix.Add(matrix[top][j]);
            }

            top++;

            for (var i = top; i <= bottom; i++)
            {
                spiralMatrix.Add(matrix[i][right]);
            }

            right--;

            if (top <= bottom)
            {
                for (var j = right; j >= left; j--)
                {
                    spiralMatrix.Add(matrix[bottom][j]);
                }

                bottom--;
            }

            if (left <= right)
            {
                for (var i = bottom; i >= top; i--)
                {
                    spiralMatrix.Add(matrix[i][left]);
                }

                left++;
            }
        }

        return spiralMatrix;
    }
}