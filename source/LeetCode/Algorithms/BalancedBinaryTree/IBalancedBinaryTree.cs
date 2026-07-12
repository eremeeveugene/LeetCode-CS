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

namespace LeetCode.Algorithms.BalancedBinaryTree;

/// <summary>
///     https://leetcode.com/problems/balanced-binary-tree/
/// </summary>
public interface IBalancedBinaryTree
{
    /// <summary>
    ///     Determines whether the binary tree rooted at <paramref name="root" /> is height-balanced.
    /// </summary>
    /// <param name="root">The root node of the binary tree.</param>
    /// <returns><see langword="true" /> if the tree is height-balanced; otherwise, <see langword="false" />.</returns>
    bool IsBalanced(TreeNode? root);
}