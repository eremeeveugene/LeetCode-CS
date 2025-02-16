// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.MatrixDiagonalSum;

/// <inheritdoc />
public class MatrixDiagonalSumIterative : IMatrixDiagonalSum
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="mat"></param>
    /// <returns></returns>
    public int DiagonalSum(int[][] mat)
    {
        var result = 0;

        for (var i = 0; i < mat.Length; i++)
        {
            result += mat[i][i];
            result += mat[i][mat.Length - i - 1];
        }

        if (mat.Length % 2 != 0)
        {
            result -= mat[mat.Length / 2][mat.Length / 2];
        }

        return result;
    }
}