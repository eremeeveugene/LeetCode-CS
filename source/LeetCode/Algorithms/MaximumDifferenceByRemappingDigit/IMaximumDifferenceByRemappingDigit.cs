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

namespace LeetCode.Algorithms.MaximumDifferenceByRemappingDigit;

/// <summary>
///     https://leetcode.com/problems/maximum-difference-by-remapping-a-digit/description/
/// </summary>
public interface IMaximumDifferenceByRemappingDigit
{
    /// <summary>
    ///     Computes the difference between the maximum and minimum values obtainable from <paramref name="num" /> by
    ///     remapping a single digit (every occurrence) to another digit exactly once for each transformation.
    /// </summary>
    /// <param name="num">The non-negative integer whose digits may be remapped.</param>
    /// <returns>The difference between the largest and smallest values obtainable by a single digit remapping applied to <paramref name="num" />.</returns>
    int MinMaxDifference(int num);
}