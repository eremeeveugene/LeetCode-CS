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

namespace LeetCode.Algorithms.SameTree;

/// <summary>
///     https://leetcode.com/problems/same-tree/description/
/// </summary>
public interface ISameTree
{
    /// <summary>
    ///     Determines whether binary trees <paramref name="p" /> and <paramref name="q" /> are structurally
    ///     identical and have the same node values.
    /// </summary>
    /// <param name="p">The root of the first binary tree.</param>
    /// <param name="q">The root of the second binary tree.</param>
    /// <returns><see langword="true" /> if the trees are the same; otherwise, <see langword="false" />.</returns>
    bool IsSameTree(TreeNode? p, TreeNode? q);
}