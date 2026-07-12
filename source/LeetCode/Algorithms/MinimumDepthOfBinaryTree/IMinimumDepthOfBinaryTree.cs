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

namespace LeetCode.Algorithms.MinimumDepthOfBinaryTree;

/// <summary>
///     https://leetcode.com/problems/minimum-depth-of-binary-tree/
/// </summary>
public interface IMinimumDepthOfBinaryTree
{
    /// <summary>
    ///     Finds the minimum depth of the binary tree rooted at <paramref name="root" />, defined as the number of
    ///     nodes along the shortest path from the root to the nearest leaf.
    /// </summary>
    /// <param name="root">The root of the binary tree.</param>
    /// <returns>The minimum depth of the tree.</returns>
    int MinDepth(TreeNode? root);
}