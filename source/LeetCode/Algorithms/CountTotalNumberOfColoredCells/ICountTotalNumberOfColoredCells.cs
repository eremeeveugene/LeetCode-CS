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

namespace LeetCode.Algorithms.CountTotalNumberOfColoredCells;

/// <summary>
///     https://leetcode.com/problems/count-total-number-of-colored-cells/description/
/// </summary>
public interface ICountTotalNumberOfColoredCells
{
    /// <summary>
    ///     Computes the total number of colored cells after <paramref name="n" /> minutes of the diamond-shaped growth
    ///     pattern starting from a single cell.
    /// </summary>
    /// <param name="n">The number of minutes the coloring process runs for, including the first minute.</param>
    /// <returns>The total number of colored cells after <paramref name="n" /> minutes.</returns>
    long ColoredCells(int n);
}