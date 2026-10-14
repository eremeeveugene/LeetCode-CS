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

namespace LeetCode.Algorithms.CountCoveredBuildings;

/// <inheritdoc />
public sealed class CountCoveredBuildingsSimulation : ICountCoveredBuildings
{
    private const int MaxStackAllocLength = 1024;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m + n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int CountCoveredBuildings(int n, int[][] buildings)
    {
        var length = n + 1;

        Span<int> maxRow = length <= MaxStackAllocLength ? stackalloc int[length] : new int[length];
        Span<int> minRow = length <= MaxStackAllocLength ? stackalloc int[length] : new int[length];
        Span<int> maxCol = length <= MaxStackAllocLength ? stackalloc int[length] : new int[length];
        Span<int> minCol = length <= MaxStackAllocLength ? stackalloc int[length] : new int[length];

        minRow.Fill(n + 1);
        minCol.Fill(n + 1);

        for (var i = 0; i < buildings.Length; i++)
        {
            var building = buildings[i];

            var x = building[0];
            var y = building[1];

            maxRow[y] = Math.Max(maxRow[y], x);
            minRow[y] = Math.Min(minRow[y], x);
            maxCol[x] = Math.Max(maxCol[x], y);
            minCol[x] = Math.Min(minCol[x], y);
        }

        var count = 0;

        for (var i = 0; i < buildings.Length; i++)
        {
            var building = buildings[i];

            var x = building[0];
            var y = building[1];

            if (x > minRow[y] && x < maxRow[y] && y > minCol[x] && y < maxCol[x])
            {
                count++;
            }
        }

        return count;
    }
}