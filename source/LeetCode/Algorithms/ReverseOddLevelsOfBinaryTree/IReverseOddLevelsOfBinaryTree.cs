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

namespace LeetCode.Algorithms.ReverseOddLevelsOfBinaryTree;

/// <summary>
///     https://leetcode.com/problems/reverse-odd-levels-of-binary-tree/
/// </summary>
public interface IReverseOddLevelsOfBinaryTree
{
    /// <summary>
    ///     Reverses the node values at every odd depth level of the perfect binary tree rooted at
    ///     <paramref name="root" />.
    /// </summary>
    /// <param name="root">The root of the perfect binary tree.</param>
    /// <returns>The root of the binary tree after the odd-level node values have been reversed.</returns>
    TreeNode? ReverseOddLevels(TreeNode? root);
}