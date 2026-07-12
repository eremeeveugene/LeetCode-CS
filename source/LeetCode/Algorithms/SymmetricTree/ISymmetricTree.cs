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

namespace LeetCode.Algorithms.SymmetricTree;

/// <summary>
///     https://leetcode.com/problems/symmetric-tree/
/// </summary>
public interface ISymmetricTree
{
    /// <summary>
    ///     Determines whether the binary tree rooted at <paramref name="root" /> is a mirror of itself around its
    ///     center.
    /// </summary>
    /// <param name="root">The root of the binary tree to check.</param>
    /// <returns><see langword="true" /> if the tree is symmetric; otherwise, <see langword="false" />.</returns>
    bool IsSymmetric(TreeNode? root);
}