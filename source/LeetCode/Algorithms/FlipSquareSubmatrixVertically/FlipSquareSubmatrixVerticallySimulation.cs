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

namespace LeetCode.Algorithms.FlipSquareSubmatrixVertically;

/// <inheritdoc />
public sealed class FlipSquareSubmatrixVerticallySimulation : IFlipSquareSubmatrixVertically
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(k^2)
    ///     Space complexity - O(1)
    /// </remarks>
    public int[][] ReverseSubmatrix(int[][] grid, int x, int y, int k)
    {
        var endRow = x + k - 1;
        var endColumn = y + k;

        for (var j = y; j < endColumn; j++)
        {
            var left = x;
            var right = endRow;

            while (left < right)
            {
                (grid[left][j], grid[right][j]) = (grid[right][j], grid[left][j]);

                left++;
                right--;
            }
        }

        return grid;
    }
}