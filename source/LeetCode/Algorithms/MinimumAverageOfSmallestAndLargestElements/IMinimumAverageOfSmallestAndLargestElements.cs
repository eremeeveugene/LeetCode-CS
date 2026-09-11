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

namespace LeetCode.Algorithms.MinimumAverageOfSmallestAndLargestElements;

/// <summary>
///     https://leetcode.com/problems/minimum-average-of-smallest-and-largest-elements/description/
/// </summary>
public interface IMinimumAverageOfSmallestAndLargestElements
{
    /// <summary>
    ///     Returns the minimum average obtained by repeatedly removing the smallest and largest elements.
    /// </summary>
    /// <param name="nums">An even-length array of integers.</param>
    /// <returns>The minimum average of a removed pair.</returns>
    double MinimumAverage(int[] nums);
}