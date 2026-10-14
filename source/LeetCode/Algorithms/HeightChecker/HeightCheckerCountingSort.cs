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
public sealed class HeightCheckerCountingSort : IHeightChecker
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + k), where n is the number of elements in the input array and k is the range of the input
    ///     values
    ///     Space complexity - O(n)
    /// </remarks>
    public int HeightChecker(int[] heights)
    {
        var maxHeight = 0;

        for (var i = 0; i < heights.Length; i++)
        {
            maxHeight = Math.Max(maxHeight, heights[i]);
        }

        var count = new int[maxHeight + 1];

        for (var i = 0; i < heights.Length; i++)
        {
            var height = heights[i];

            count[height]++;
        }

        var result = 0;
        var currentHeight = 0;

        for (var i = 0; i < heights.Length; i++)
        {
            var height = heights[i];

            while (count[currentHeight] == 0)
            {
                currentHeight++;
            }

            if (currentHeight != height)
            {
                result++;
            }

            count[currentHeight]--;
        }

        return result;
    }
}