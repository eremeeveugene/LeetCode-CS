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

namespace LeetCode.Algorithms.MinimumTimeToMakeRopeColorful;

/// <summary>
///     https://leetcode.com/problems/minimum-time-to-make-rope-colorful/description/
/// </summary>
public interface IMinimumTimeToMakeRopeColorful
{
    /// <summary>
    ///     Calculates the minimum total removal time needed so that no two consecutive balloons in
    ///     <paramref name="colors" /> share the same color, where removing the balloon at index <c>i</c>
    ///     costs <c>neededTime[i]</c> seconds.
    /// </summary>
    /// <param name="colors">A string where each character is the color of the balloon at that index.</param>
    /// <param name="neededTime">An array where each element is the removal time of the balloon at that index.</param>
    /// <returns>The minimum total time required to make the rope colorful.</returns>
    int MinCost(string colors, int[] neededTime);
}