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

namespace LeetCode.Algorithms.RowWithMaximumOnes;

/// <inheritdoc />
public sealed class RowWithMaximumOnesBruteForce : IRowWithMaximumOnes
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    public int[] RowAndMaximumOnes(int[][] mat)
    {
        var index = 0;
        var maxCount = 0;

        for (var i = 0; i < mat.Length; i++)
        {
            var count = mat[i].Sum();

            if (count <= maxCount)
            {
                continue;
            }

            maxCount = count;
            index = i;
        }

        return [index, maxCount];
    }
}