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

namespace LeetCode.Algorithms.FindTheHighestAltitude;

/// <summary>
///     https://leetcode.com/problems/find-the-highest-altitude/description
/// </summary>
public interface IFindTheHighestAltitude
{
    /// <summary>
    ///     A biker starts a trip at point <c>0</c> with altitude <c>0</c> and rides through <c>n + 1</c> points, where
    ///     <paramref name="gains" /> of length <c>n</c> gives the net altitude change between consecutive points
    ///     (<c>gains[i]</c> is the change between points <c>i</c> and <c>i + 1</c> for <c>0 &lt;= i &lt; n</c>).
    /// </summary>
    /// <param name="gains">The net altitude changes between each pair of consecutive points.</param>
    /// <returns>The highest altitude reached among all points, including the starting altitude of <c>0</c>.</returns>
    int LargestAltitude(int[] gains);
}