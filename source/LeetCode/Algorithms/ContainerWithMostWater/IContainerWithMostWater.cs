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

namespace LeetCode.Algorithms.ContainerWithMostWater;

/// <summary>
///     https://leetcode.com/problems/container-with-most-water/description/
/// </summary>
public interface IContainerWithMostWater
{
    /// <summary>
    ///     Finds two lines from <paramref name="heights" /> that, together with the x-axis, form a container that holds
    ///     the maximum amount of water.
    /// </summary>
    /// <param name="heights">The array of line heights.</param>
    /// <returns>The maximum amount of water that can be contained.</returns>
    int MaxArea(int[] heights);
}