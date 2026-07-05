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

namespace LeetCode.Algorithms.Search2DMatrix;

/// <inheritdoc />
public sealed class Search2DMatrixRowColumnBinarySearch : ISearch2DMatrix
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log m + log n), where m is the number of rows and n is the number of columns
    ///     Space complexity - O(1)
    /// </remarks>
    public bool SearchMatrix(int[][] matrix, int target)
    {
        var m = matrix.Length;

        var top = 0;
        var bottom = m - 1;

        while (top <= bottom)
        {
            var mid = top + ((bottom - top) / 2);

            if (matrix[mid][0] <= target)
            {
                top = mid + 1;
            }
            else
            {
                bottom = mid - 1;
            }
        }

        var row = bottom;

        if (row < 0)
        {
            return false;
        }

        var n = matrix[0].Length;

        var left = 0;
        var right = n - 1;

        while (left <= right)
        {
            var mid = left + ((right - left) / 2);

            if (matrix[row][mid] == target)
            {
                return true;
            }

            if (matrix[row][mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return false;
    }
}