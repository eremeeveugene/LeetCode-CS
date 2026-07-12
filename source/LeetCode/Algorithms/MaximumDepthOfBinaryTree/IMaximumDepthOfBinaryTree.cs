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

namespace LeetCode.Algorithms.MaximumDepthOfBinaryTree;

/// <summary>
///     https://leetcode.com/problems/maximum-depth-of-binary-tree/description/
/// </summary>
public interface IMaximumDepthOfBinaryTree
{
    /// <summary>
    ///     Computes the maximum depth of the binary tree rooted at <paramref name="root" />.
    /// </summary>
    /// <param name="root">The root node of the binary tree, or <see langword="null" /> for an empty tree.</param>
    /// <returns>The number of nodes along the longest path from <paramref name="root" /> down to the farthest leaf node.</returns>
    int MaxDepth(TreeNode? root);
}