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

namespace LeetCode.Algorithms.ConstructBinaryTreeFromPreorderAndPostorderTraversal;

/// <summary>
///     https://leetcode.com/problems/construct-binary-tree-from-preorder-and-postorder-traversal/description/
/// </summary>
public interface IConstructBinaryTreeFromPreorderAndPostorderTraversal
{
    /// <summary>
    ///     Constructs a binary tree from its <paramref name="preorder" /> and <paramref name="postorder" /> traversals.
    /// </summary>
    /// <param name="preorder">The preorder traversal of the tree.</param>
    /// <param name="postorder">The postorder traversal of the tree.</param>
    /// <returns>The root node of the reconstructed binary tree.</returns>
    TreeNode ConstructFromPrePost(int[] preorder, int[] postorder);
}