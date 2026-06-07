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

namespace LeetCode.Algorithms.CreateBinaryTreeFromDescriptions;

/// <summary>
///     https://leetcode.com/problems/create-binary-tree-from-descriptions/description/
/// </summary>
public interface ICreateBinaryTreeFromDescriptions
{
    /// <summary>
    ///     Builds a binary tree from the given parent-child relationships and returns its root.
    /// </summary>
    /// <param name="descriptions">
    ///     A 2D array where each entry <c>[parent, child, isLeft]</c> attaches <c>child</c> to <c>parent</c>
    ///     as a left child when <c>isLeft == 1</c> and as a right child when <c>isLeft == 0</c>.
    /// </param>
    /// <returns>
    ///     The root <see cref="TreeNode" /> of the binary tree described by <paramref name="descriptions" />,
    ///     or <see langword="null" /> when <paramref name="descriptions" /> is empty.
    /// </returns>
    TreeNode? CreateBinaryTree(int[][] descriptions);
}