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

namespace LeetCode.Algorithms.NearestAvailableDrone;

/// <summary>
///     https://leetcode.com/problems/nearest-available-drone/description/
/// </summary>
public interface INearestAvailableDrone
{
    /// <summary>
    ///     Finds the index of the reachable drone with the minimum Manhattan distance to the target.
    /// </summary>
    /// <param name="drones">The drones, where each entry contains an x-coordinate, y-coordinate, and travel range.</param>
    /// <param name="target">The target coordinates.</param>
    /// <returns>The nearest reachable drone index, or -1 if no drone can reach the target.</returns>
    int NearestDrone(int[][] drones, int[] target);
}