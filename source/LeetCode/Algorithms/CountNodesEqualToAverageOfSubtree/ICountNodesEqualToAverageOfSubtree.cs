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

using LeetCode.Core.Models;

namespace LeetCode.Algorithms.CountNodesEqualToAverageOfSubtree;

/// <summary>
///     https://leetcode.com/problems/count-nodes-equal-to-average-of-subtree/description/
/// </summary>
public interface ICountNodesEqualToAverageOfSubtree
{
    /// <summary>
    ///     Counts nodes whose value equals the average of their subtree, rounded down.
    /// </summary>
    /// <param name="root">The root of the nonempty binary tree.</param>
    /// <returns>The number of nodes equal to their subtree average.</returns>
    int AverageOfSubtree(TreeNode root);
}