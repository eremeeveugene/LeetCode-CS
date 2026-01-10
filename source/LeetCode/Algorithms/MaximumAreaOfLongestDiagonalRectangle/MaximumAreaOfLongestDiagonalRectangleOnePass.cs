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

namespace LeetCode.Algorithms.MaximumAreaOfLongestDiagonalRectangle;

/// <inheritdoc />
public sealed class MaximumAreaOfLongestDiagonalRectangleOnePass : IMaximumAreaOfLongestDiagonalRectangle
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="dimensions"></param>
    /// <returns></returns>
    public int AreaOfMaxDiagonal(int[][] dimensions)
    {
        var longestDiagonal = 0;
        var maximumArea = 0;

        foreach (var dimension in dimensions)
        {
            var length = dimension[0];
            var width = dimension[1];

            var currentDiagonal = (length * length) + (width * width);

            if (currentDiagonal < longestDiagonal)
            {
                continue;
            }

            var currentArea = length * width;

            if (currentDiagonal == longestDiagonal)
            {
                maximumArea = Math.Max(maximumArea, currentArea);
            }
            else
            {
                longestDiagonal = currentDiagonal;
                maximumArea = currentArea;
            }
        }

        return maximumArea;
    }
}