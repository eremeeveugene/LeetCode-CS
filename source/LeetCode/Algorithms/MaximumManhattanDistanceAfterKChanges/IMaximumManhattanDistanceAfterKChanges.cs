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

namespace LeetCode.Algorithms.MaximumManhattanDistanceAfterKChanges;

/// <summary>
///     https://leetcode.com/problems/maximum-manhattan-distance-after-k-changes/description/
/// </summary>
public interface IMaximumManhattanDistanceAfterKChanges
{
    /// <summary>
    ///     Finds the greatest Manhattan distance reached at any point after changing at most k movements.
    /// </summary>
    /// <param name="s">The sequence of north, south, east, and west movements.</param>
    /// <param name="k">The maximum number of movements that can be changed.</param>
    /// <returns>The maximum Manhattan distance from the origin reached during the movements.</returns>
    int MaxDistance(string s, int k);
}