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

namespace LeetCode.Algorithms.MinimumCostToHireKWorkers;

/// <summary>
///     https://leetcode.com/problems/minimum-cost-to-hire-k-workers/description/
/// </summary>
public interface IMinimumCostToHireKWorkers
{
    /// <summary>
    ///     Hires exactly <paramref name="k" /> workers, given each worker's <paramref name="quality" /> and minimum
    ///     acceptable <paramref name="wage" />, such that pay is proportional to quality and every hired worker is
    ///     paid at least their minimum wage expectation, while minimizing the total cost.
    /// </summary>
    /// <param name="quality">The quality value of each worker.</param>
    /// <param name="wage">The minimum wage expectation of each worker.</param>
    /// <param name="k">The number of workers that must be hired.</param>
    /// <returns>The minimum total cost to hire exactly <paramref name="k" /> workers.</returns>
    double MincostToHireWorkers(int[] quality, int[] wage, int k);
}