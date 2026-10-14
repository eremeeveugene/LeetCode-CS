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

namespace LeetCode.Algorithms.HeightChecker;

/// <inheritdoc />
public sealed class HeightCheckerSorting : IHeightChecker
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int HeightChecker(int[] heights)
    {
        var sortedHeights = new int[heights.Length];

        Array.Copy(heights, sortedHeights, heights.Length);

        Array.Sort(sortedHeights);

        var result = 0;

        for (var i = 0; i < heights.Length; i++)
        {
            if (sortedHeights[i] != heights[i])
            {
                result++;
            }
        }

        return result;
    }
}