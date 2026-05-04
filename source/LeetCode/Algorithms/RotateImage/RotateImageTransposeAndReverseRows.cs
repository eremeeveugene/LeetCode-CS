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

namespace LeetCode.Algorithms.RotateImage;

/// <inheritdoc />
public sealed class RotateImageTransposeAndReverseRows : IRotateImage
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Rotate(int[][] matrix)
    {
        Transpose(matrix);
        ReverseRows(matrix);
    }

    /// <summary>
    ///     Transposes the specified square matrix in-place (swaps matrix[i][j] with matrix[j][i]).
    /// </summary>
    /// <param name="matrix">The square matrix to transpose.</param>
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    private static void Transpose(int[][] matrix)
    {
        var n = matrix.Length;

        for (var i = 0; i < n; i++)
        {
            for (var j = i + 1; j < n; j++)
            {
                (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
            }
        }
    }

    /// <summary>
    ///     Reverses each row of the specified matrix in-place.
    /// </summary>
    /// <param name="matrix">The matrix whose rows will be reversed.</param>
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    private static void ReverseRows(int[][] matrix)
    {
        var n = matrix.Length;

        for (var i = 0; i < n; i++)
        {
            var row = matrix[i];

            var k = n - 1;

            for (var j = 0; j < k; j++)
            {
                (row[j], row[k]) = (row[k], row[j]);

                k--;
            }
        }
    }
}