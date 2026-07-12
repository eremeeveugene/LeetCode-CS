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

namespace LeetCode.Algorithms.FirstCompletelyPaintedRowOrColumn;

/// <inheritdoc />
public sealed class FirstCompletelyPaintedRowOrColumnDictionary : IFirstCompletelyPaintedRowOrColumn
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m * n)
    /// </remarks>
    public int FirstCompleteIndex(int[] arr, int[][] mat)
    {
        var numsDictionary = new Dictionary<int, int>();

        for (var i = 0; i < arr.Length; i++)
        {
            numsDictionary.Add(arr[i], i);
        }

        var result = int.MaxValue;
        var m = mat.Length;
        var n = mat[0].Length;

        for (var i = 0; i < m; i++)
        {
            var index = int.MinValue;

            for (var j = 0; j < n; j++)
            {
                index = Math.Max(index, numsDictionary[mat[i][j]]);
            }

            result = Math.Min(result, index);
        }

        for (var i = 0; i < n; i++)
        {
            var index = int.MinValue;

            for (var j = 0; j < m; j++)
            {
                index = Math.Max(index, numsDictionary[mat[j][i]]);
            }

            result = Math.Min(result, index);
        }

        return result;
    }
}