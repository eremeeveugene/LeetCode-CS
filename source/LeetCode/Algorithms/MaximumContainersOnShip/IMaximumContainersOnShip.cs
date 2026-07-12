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

namespace LeetCode.Algorithms.MaximumContainersOnShip;

/// <summary>
///     https://leetcode.com/problems/maximum-containers-on-a-ship/description/
/// </summary>
public interface IMaximumContainersOnShip
{
    /// <summary>
    ///     Computes the maximum number of containers, each weighing <paramref name="w" />, that can be loaded onto an
    ///     <paramref name="n" /> x <paramref name="n" /> grid ship without exceeding <paramref name="maxWeight" />.
    /// </summary>
    /// <param name="n">The side length of the square grid representing the ship's available container slots.</param>
    /// <param name="w">The weight of each container.</param>
    /// <param name="maxWeight">The maximum total weight the ship can carry.</param>
    /// <returns>The maximum number of containers that can be loaded onto the ship.</returns>
    int MaxContainers(int n, int w, int maxWeight);
}