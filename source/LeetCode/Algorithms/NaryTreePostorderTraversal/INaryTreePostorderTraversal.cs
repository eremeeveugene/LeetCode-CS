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

namespace LeetCode.Algorithms.NaryTreePostorderTraversal;

/// <summary>
///     https://leetcode.com/problems/n-ary-tree-postorder-traversal/
/// </summary>
public interface INaryTreePostorderTraversal
{
    /// <summary>
    ///     Performs a postorder traversal of the N-ary tree rooted at <paramref name="root" /> and returns the node
    ///     values in visitation order.
    /// </summary>
    /// <param name="root">The root node of the N-ary tree, or <see langword="null" /> for an empty tree.</param>
    /// <returns>The values of the tree's nodes in postorder.</returns>
    IList<int> Postorder(Node? root);
}