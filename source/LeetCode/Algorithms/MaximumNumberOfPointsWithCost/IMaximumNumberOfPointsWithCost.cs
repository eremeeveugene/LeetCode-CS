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

namespace LeetCode.Algorithms.MaximumNumberOfPointsWithCost;

/// <summary>
///     https://leetcode.com/problems/maximum-number-of-points-with-cost/
/// </summary>
public interface IMaximumNumberOfPointsWithCost
{
    /// <summary>
    ///     Selects one cell per row of <paramref name="points" /> to maximize the total of the selected cell values
    ///     minus, for each pair of consecutive rows, the absolute difference in the columns chosen.
    /// </summary>
    /// <param name="points">The matrix of point values, where a value is selected from each row.</param>
    /// <returns>The maximum total score achievable by selecting one cell from each row of <paramref name="points" />.</returns>
    long MaxPoints(int[][] points);
}