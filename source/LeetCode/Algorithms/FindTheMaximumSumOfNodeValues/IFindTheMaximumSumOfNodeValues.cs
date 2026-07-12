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

namespace LeetCode.Algorithms.FindTheMaximumSumOfNodeValues;

/// <summary>
///     https://leetcode.com/problems/find-the-maximum-sum-of-node-values/
/// </summary>
public interface IFindTheMaximumSumOfNodeValues
{
    /// <summary>
    ///     Finds the maximum possible sum of node values in a tree after performing any number of operations, where each
    ///     operation XORs the values of two nodes connected by an edge with <paramref name="k" />.
    /// </summary>
    /// <param name="nums">The values of the tree nodes.</param>
    /// <param name="k">The value used in the XOR operations.</param>
    /// <param name="edges">The edges of the tree.</param>
    /// <returns>The maximum possible sum of node values.</returns>
    long MaximumValueSum(int[] nums, int k, int[][] edges);
}