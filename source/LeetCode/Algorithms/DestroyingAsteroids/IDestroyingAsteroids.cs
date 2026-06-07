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

namespace LeetCode.Algorithms.DestroyingAsteroids;

/// <summary>
///     https://leetcode.com/problems/destroying-asteroids/description/
/// </summary>
public interface IDestroyingAsteroids
{
    /// <summary>
    ///     Determines whether the planet can destroy all asteroids by colliding with them in some order.
    /// </summary>
    /// <param name="mass">The initial mass of the planet.</param>
    /// <param name="asteroids">An array where each element represents the mass of an asteroid.</param>
    /// <returns><c>true</c> if all asteroids can be destroyed; otherwise, <c>false</c>.</returns>
    bool AsteroidsDestroyed(int mass, int[] asteroids);
}