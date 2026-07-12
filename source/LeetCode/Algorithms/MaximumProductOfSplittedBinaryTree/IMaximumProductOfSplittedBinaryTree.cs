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

namespace LeetCode.Algorithms.MaximumProductOfSplittedBinaryTree;

/// <summary>
///     https://leetcode.com/problems/maximum-product-of-splitted-binary-tree/description/
/// </summary>
public interface IMaximumProductOfSplittedBinaryTree
{
    /// <summary>
    ///     Removes one edge from the binary tree rooted at <paramref name="root" /> to split it into two subtrees,
    ///     maximizing the product of the two subtrees' sums of node values.
    /// </summary>
    /// <param name="root">The root node of the binary tree to split.</param>
    /// <returns>The maximum product of the sums of the two subtrees, modulo 10^9 + 7.</returns>
    int MaxProduct(TreeNode root);
}