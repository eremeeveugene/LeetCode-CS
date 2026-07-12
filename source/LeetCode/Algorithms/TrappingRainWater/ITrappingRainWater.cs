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

namespace LeetCode.Algorithms.TrappingRainWater;

/// <summary>
///     https://leetcode.com/problems/trapping-rain-water/description/
/// </summary>
public interface ITrappingRainWater
{
    /// <summary>
    ///     Computes the total volume of rainwater trapped between bars whose heights are given by
    ///     <paramref name="height" />.
    /// </summary>
    /// <param name="height">The array of non-negative integers representing the elevation map's bar heights.</param>
    /// <returns>The total amount of water that can be trapped after raining.</returns>
    int Trap(int[] height);
}