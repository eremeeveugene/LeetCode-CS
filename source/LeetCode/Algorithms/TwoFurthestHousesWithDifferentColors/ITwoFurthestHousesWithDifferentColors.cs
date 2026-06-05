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

/// <summary>
///     https://leetcode.com/problems/two-furthest-houses-with-different-colors/description/
/// </summary>
public interface ITwoFurthestHousesWithDifferentColors
{
    /// <summary>
    ///     Finds the maximum distance between any two houses painted with different colors.
    /// </summary>
    /// <param name="colors">An array where each element represents the color of a house.</param>
    /// <returns>The maximum distance between two houses with different colors.</returns>
    int MaxDistance(int[] colors);
}