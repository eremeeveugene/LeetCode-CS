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

namespace LeetCode.Algorithms.BinaryTreeInorderTraversal;

/// <summary>
///     https://leetcode.com/problems/binary-tree-inorder-traversal/description/
/// </summary>
public interface IBinaryTreeInorderTraversal
{
    /// <summary>
    ///     Returns the inorder traversal of the values of the binary tree rooted at <paramref name="treeNode" />.
    /// </summary>
    /// <param name="treeNode">The root of the binary tree.</param>
    /// <returns>The node values in inorder order.</returns>
    IList<int> InorderTraversal(TreeNode? treeNode);
}