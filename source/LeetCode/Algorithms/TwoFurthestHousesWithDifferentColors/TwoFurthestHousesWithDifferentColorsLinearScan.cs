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
public sealed class TwoFurthestHousesWithDifferentColorsLinearScan : ITwoFurthestHousesWithDifferentColors
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaxDistance(int[] colors)
    {
        var n = colors.Length;

        var maxDistance = 0;

        var firstColor = colors[0];
        var lastColor = colors[^1];

        for (var i = 0; i < n - 1; i++)
        {
            var color = colors[i];

            if (color != firstColor)
            {
                maxDistance = Math.Max(maxDistance, i);
            }

            if (color != lastColor)
            {
                maxDistance = Math.Max(maxDistance, n - 1 - i);
            }
        }

        return maxDistance;
    }
}