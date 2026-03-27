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

namespace LeetCode.Algorithms.MatrixSimilarityAfterCyclicShifts;

/// <inheritdoc />
public sealed class MatrixSimilarityAfterCyclicShiftsMath : IMatrixSimilarityAfterCyclicShifts
{
    /// <summary>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="mat"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public bool AreSimilar(int[][] mat, int k)
    {
        var m = mat.Length;
        var n = mat[0].Length;

        k %= n;

        for (var i = 0; i < m; i++)
        {
            var row = mat[i];

            for (var j = 0; j < n; j++)
            {
                if (row[j] != row[(j + k) % n])
                {
                    return false;
                }
            }
        }

        return true;
    }
}