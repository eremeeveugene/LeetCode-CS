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
public sealed class Search2DMatrixFlattenedBinarySearch : ISearch2DMatrix
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log(m * n)), where m is the number of rows and n is the number of columns
    ///     Space complexity - O(1)
    /// </remarks>
    public bool SearchMatrix(int[][] matrix, int target)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;

        var low = 0;
        var high = (m * n) - 1;

        while (low <= high)
        {
            var mid = low + ((high - low) / 2);

            var value = matrix[mid / n][mid % n];

            if (value == target)
            {
                return true;
            }

            if (value < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return false;
    }
}