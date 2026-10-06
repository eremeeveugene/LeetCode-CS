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

namespace LeetCode.Algorithms.SetIntersectionSizeAtLeastTwo;

/// <summary>
///     https://leetcode.com/problems/set-intersection-size-at-least-two/description/
/// </summary>
public interface ISetIntersectionSizeAtLeastTwo
{
    /// <summary>
    ///     Finds the minimum size of a set that shares at least two integers with every given interval.
    /// </summary>
    /// <param name="intervals">The array of inclusive intervals, each given as a start and an end.</param>
    /// <returns>The minimum size of a containing set.</returns>
    int IntersectionSizeTwo(int[][] intervals);
}