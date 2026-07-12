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

namespace LeetCode.Algorithms.DiameterOfBinaryTree;

/// <summary>
///     https://leetcode.com/problems/diameter-of-binary-tree/
/// </summary>
public interface IDiameterOfBinaryTree
{
    /// <summary>
    ///     Computes the diameter of the binary tree, i.e. the length of the longest path between any two nodes, measured in
    ///     the number of edges.
    /// </summary>
    /// <param name="root">The root node of the binary tree.</param>
    /// <returns>The length of the longest path between any two nodes in the tree.</returns>
    int DiameterOfBinaryTree(TreeNode? root);
}