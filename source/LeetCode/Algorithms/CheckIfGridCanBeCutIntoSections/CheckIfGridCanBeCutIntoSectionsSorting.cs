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

namespace LeetCode.Algorithms.CheckIfGridCanBeCutIntoSections;

/// <inheritdoc />
public sealed class CheckIfGridCanBeCutIntoSectionsSorting : ICheckIfGridCanBeCutIntoSections
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </remarks>
    public bool CheckValidCuts(int n, int[][] rectangles)
    {
        return CheckCuts(rectangles, 0) || CheckCuts(rectangles, 1);
    }

    private static bool CheckCuts(int[][] rectangles, int dimension)
    {
        Array.Sort(rectangles, (a, b) => a[dimension].CompareTo(b[dimension]));

        var gapCount = 0;
        var furthestEnd = rectangles[0][dimension + 2];

        for (var i = 1; i < rectangles.Length; i++)
        {
            var start = rectangles[i][dimension];
            var end = rectangles[i][dimension + 2];

            if (furthestEnd <= start)
            {
                gapCount++;

                if (gapCount >= 2)
                {
                    return true;
                }
            }

            furthestEnd = Math.Max(furthestEnd, end);
        }

        return false;
    }
}