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

namespace LeetCode.Algorithms.NaryTreeLevelOrderTraversal;

/// <summary>
///     https://leetcode.com/problems/n-ary-tree-level-order-traversal/description/
/// </summary>
public interface INaryTreeLevelOrderTraversal
{
    /// <summary>
    ///     Traverses the N-ary tree rooted at <paramref name="root" /> level by level and returns the node values
    ///     grouped by level.
    /// </summary>
    /// <param name="root">The root node of the N-ary tree, or <see langword="null" /> for an empty tree.</param>
    /// <returns>A list of levels, each containing the values of the nodes at that level, from top to bottom.</returns>
    IList<IList<int>> LevelOrder(Node? root);
}