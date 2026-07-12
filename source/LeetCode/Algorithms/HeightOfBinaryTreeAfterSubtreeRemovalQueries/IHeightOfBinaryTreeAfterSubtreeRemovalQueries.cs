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

namespace LeetCode.Algorithms.HeightOfBinaryTreeAfterSubtreeRemovalQueries;

/// <summary>
///     https://leetcode.com/problems/height-of-binary-tree-after-subtree-removal-queries/description/
/// </summary>
public interface IHeightOfBinaryTreeAfterSubtreeRemovalQueries
{
    /// <summary>
    ///     Computes, for each query in <paramref name="queries" />, the height of the binary tree rooted at
    ///     <paramref name="root" /> after removing the subtree rooted at the node with the queried value. Queries are
    ///     independent, so the tree returns to its initial state after each query.
    /// </summary>
    /// <param name="root">The root of the binary tree.</param>
    /// <param name="queries">The values of the nodes whose subtrees are removed.</param>
    /// <returns>The heights of the tree after performing each query.</returns>
    int[] TreeQueries(TreeNode root, int[] queries);
}