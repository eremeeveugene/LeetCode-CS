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

namespace LeetCode.Algorithms.MaximumNumberOfKDivisibleComponents;

/// <summary>
///     https://leetcode.com/problems/maximum-number-of-k-divisible-components/description/
/// </summary>
public interface IMaximumNumberOfKDivisibleComponents
{
    /// <summary>
    ///     Determines the maximum number of connected components obtainable by removing edges from the tree of
    ///     <paramref name="n" /> nodes described by <paramref name="edges" />, such that the sum of <paramref name="values" />
    ///     within every resulting component is divisible by <paramref name="k" />.
    /// </summary>
    /// <param name="n">The number of nodes in the tree.</param>
    /// <param name="edges">The array of edges connecting the nodes of the tree.</param>
    /// <param name="values">The array of values associated with each node.</param>
    /// <param name="k">The divisor that the sum of values in every component must be divisible by.</param>
    /// <returns>The maximum number of k-divisible components obtainable by removing edges from the tree.</returns>
    int MaxKDivisibleComponents(int n, int[][] edges, int[] values, int k);
}