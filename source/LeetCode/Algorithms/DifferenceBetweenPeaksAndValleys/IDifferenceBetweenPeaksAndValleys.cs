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

namespace LeetCode.Algorithms.DifferenceBetweenPeaksAndValleys;

/// <summary>
///     https://leetcode.com/problems/difference-between-peaks-and-valleys/description/
/// </summary>
public interface IDifferenceBetweenPeaksAndValleys
{
    /// <summary>
    ///     Computes the difference between the sum of all peak values and the sum of all valley values in
    ///     <paramref name="nums" />.
    /// </summary>
    /// <param name="nums">The array of integers to scan for peaks and valleys.</param>
    /// <returns>The sum of the peak values minus the sum of the valley values in <paramref name="nums" />.</returns>
    int PeakValleyDifference(int[] nums);
}