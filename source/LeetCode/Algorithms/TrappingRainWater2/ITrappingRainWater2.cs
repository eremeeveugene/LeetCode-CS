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

namespace LeetCode.Algorithms.TrappingRainWater2;

/// <summary>
///     https://leetcode.com/problems/trapping-rain-water-ii/description/
/// </summary>
public interface ITrappingRainWater2
{
    /// <summary>
    ///     Computes the total volume of rainwater trapped on the 2D elevation map given by <paramref name="heightMap" />.
    /// </summary>
    /// <param name="heightMap">The matrix of non-negative integers representing the height of each unit cell.</param>
    /// <returns>The total amount of water that can be trapped after raining.</returns>
    int TrapRainWater(int[][] heightMap);
}