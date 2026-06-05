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

namespace LeetCode.Algorithms.TwoFurthestHousesWithDifferentColors;

/// <inheritdoc />
public sealed class TwoFurthestHousesWithDifferentColorsBruteForce : ITwoFurthestHousesWithDifferentColors
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaxDistance(int[] colors)
    {
        var n = colors.Length;

        var maxDistance = 0;

        for (var i = 0; i < n - 1; i++)
        {
            var colorA = colors[i];

            for (var j = n - 1; j > i; j--)
            {
                var colorB = colors[j];

                if (colorA == colorB)
                {
                    continue;
                }

                var distance = j - i;

                maxDistance = Math.Max(maxDistance, distance);
            }
        }

        return maxDistance;
    }
}