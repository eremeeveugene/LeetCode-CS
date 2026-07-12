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

namespace LeetCode.Algorithms.BinaryTreePreorderTraversal;

/// <summary>
///     https://leetcode.com/problems/binary-tree-preorder-traversal/
/// </summary>
public interface IBinaryTreePreorderTraversal
{
    /// <summary>
    ///     Returns the preorder traversal of the values of the binary tree rooted at <paramref name="root" />.
    /// </summary>
    /// <param name="root">The root of the binary tree.</param>
    /// <returns>The node values in preorder order.</returns>
    IList<int> PreorderTraversal(TreeNode? root);
}