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

namespace LeetCode.Algorithms.CountCoveredBuildings;

/// <inheritdoc />
public sealed class CountCoveredBuildingsSimulation : ICountCoveredBuildings
{
    /// <summary>
    ///     Time complexity - O(m + n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="n"></param>
    /// <param name="buildings"></param>
    /// <returns></returns>
    public int CountCoveredBuildings(int n, int[][] buildings)
    {
        Span<int> maxRow = stackalloc int[n + 1];
        Span<int> minRow = stackalloc int[n + 1];
        Span<int> maxCol = stackalloc int[n + 1];
        Span<int> minCol = stackalloc int[n + 1];

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