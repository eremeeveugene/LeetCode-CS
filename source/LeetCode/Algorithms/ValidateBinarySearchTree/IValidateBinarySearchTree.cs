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

namespace LeetCode.Algorithms.ValidateBinarySearchTree;

/// <summary>
///     https://leetcode.com/problems/validate-binary-search-tree/description/
/// </summary>
public interface IValidateBinarySearchTree
{
    /// <summary>
    ///     Determines whether the binary tree rooted at <paramref name="root" /> is a valid binary search tree, where
    ///     every node's left subtree holds only strictly smaller values and its right subtree only strictly greater
    ///     values.
    /// </summary>
    /// <param name="root">The root node of the binary tree.</param>
    /// <returns><see langword="true" /> if the tree is a valid binary search tree; otherwise, <see langword="false" />.</returns>
    bool IsValidBST(TreeNode root);
}