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

namespace LeetCode.Algorithms.FindMinimumLogTransportationCost;

/// <summary>
///     https://leetcode.com/problems/find-minimum-log-transportation-cost/description/
/// </summary>
public interface IFindMinimumLogTransportationCost
{
    /// <summary>
    ///     Computes the minimum cost of cutting the logs of lengths <paramref name="n" /> and <paramref name="m" /> so
    ///     that every piece has length at most <paramref name="k" />, where cutting a log of length x costs x.
    /// </summary>
    /// <param name="n">The length of the first log.</param>
    /// <param name="m">The length of the second log.</param>
    /// <param name="k">The maximum allowed piece length for transportation.</param>
    /// <returns>The minimum total cutting cost required to transport both logs.</returns>
    long MinCuttingCost(int n, int m, int k);
}