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

namespace LeetCode.Algorithms.MaximumLevelSumOfBinaryTree;

/// <summary>
///     https://leetcode.com/problems/maximum-level-sum-of-a-binary-tree/description/
/// </summary>
public interface IMaximumLevelSumOfBinaryTree
{
    /// <summary>
    ///     Finds the smallest level of the binary tree rooted at <paramref name="root" /> that has the maximum sum of
    ///     node values.
    /// </summary>
    /// <param name="root">The root node of the binary tree.</param>
    /// <returns>The 1-indexed level with the maximum sum of node values, choosing the smallest such level if tied.</returns>
    int MaxLevelSum(TreeNode root);
}