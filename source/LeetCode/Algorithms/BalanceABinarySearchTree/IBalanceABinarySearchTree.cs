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

namespace LeetCode.Algorithms.BalanceABinarySearchTree;

/// <summary>
///     https://leetcode.com/problems/balance-a-binary-search-tree/description/
/// </summary>
public interface IBalanceABinarySearchTree
{
    /// <summary>
    ///     Balances a binary search tree while preserving its node values.
    /// </summary>
    /// <param name="root">The root of a nonempty binary search tree.</param>
    /// <returns>The root of a height-balanced binary search tree with the same node values.</returns>
    TreeNode BalanceBST(TreeNode root);
}