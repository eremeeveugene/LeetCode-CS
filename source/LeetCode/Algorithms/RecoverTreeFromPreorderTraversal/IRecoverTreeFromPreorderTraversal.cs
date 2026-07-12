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

namespace LeetCode.Algorithms.RecoverTreeFromPreorderTraversal;

/// <summary>
///     https://leetcode.com/problems/recover-a-tree-from-preorder-traversal/description/
/// </summary>
public interface IRecoverTreeFromPreorderTraversal
{
    /// <summary>
    ///     Reconstructs the binary tree encoded by the depth-dash preorder <paramref name="traversal" /> string.
    /// </summary>
    /// <param name="traversal">The preorder traversal string, where each node's depth is denoted by leading dashes.</param>
    /// <returns>The root of the reconstructed binary tree.</returns>
    TreeNode? RecoverFromPreorder(string traversal);
}