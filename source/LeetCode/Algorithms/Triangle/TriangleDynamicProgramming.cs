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

namespace LeetCode.Algorithms.Triangle;

/// <inheritdoc />
public sealed class TriangleDynamicProgramming : ITriangle
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="triangle"></param>
    /// <returns></returns>
    public int MinimumTotal(IList<IList<int>> triangle)
    {
        var rowsCount = triangle.Count;
        var cellsCount = rowsCount;

        for (var rowIndex = rowsCount - 1; rowIndex > 0; rowIndex--)
        {
            var row = triangle[rowIndex];
            var previousRow = triangle[rowIndex - 1];

            for (var cellIndex = 0; cellIndex < cellsCount - 1; cellIndex++)
            {
                var value = row[cellIndex];
                var nextValue = row[cellIndex + 1];

                previousRow[cellIndex] += value < nextValue ? value : nextValue;
            }

            cellsCount--;
        }

        return triangle[0][0];
    }
}