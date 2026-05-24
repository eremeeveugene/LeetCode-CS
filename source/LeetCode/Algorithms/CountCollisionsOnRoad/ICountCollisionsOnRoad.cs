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

namespace LeetCode.Algorithms.CountCollisionsOnRoad;

/// <summary>
///     https://leetcode.com/problems/count-collisions-on-a-road/description/
/// </summary>
public interface ICountCollisionsOnRoad
{
    /// <summary>
    ///     Counts the number of collisions that happen on the road.
    /// </summary>
    /// <param name="directions">The string representing the directions of cars on the road.</param>
    /// <returns>The total number of collisions on the road.</returns>
    int CountCollisions(string directions);
}