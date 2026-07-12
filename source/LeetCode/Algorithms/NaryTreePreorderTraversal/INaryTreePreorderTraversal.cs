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

namespace LeetCode.Algorithms.NaryTreePreorderTraversal;

/// <summary>
///     https://leetcode.com/problems/n-ary-tree-preorder-traversal/
/// </summary>
public interface INaryTreePreorderTraversal
{
    /// <summary>
    ///     Performs a preorder traversal of the N-ary tree rooted at <paramref name="root" /> and returns the node
    ///     values in visitation order.
    /// </summary>
    /// <param name="root">The root node of the N-ary tree, or <see langword="null" /> for an empty tree.</param>
    /// <returns>The values of the tree's nodes in preorder.</returns>
    IList<int> Preorder(Node? root);
}