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

namespace LeetCode.Algorithms.DistributeCoinsInBinaryTree;

/// <summary>
///     https://leetcode.com/problems/distribute-coins-in-binary-tree/description/
/// </summary>
public interface IDistributeCoinsInBinaryTree
{
    /// <summary>
    ///     Computes the minimum number of coin moves needed so that every node in the binary tree rooted at
    ///     <paramref name="root" /> has exactly one coin.
    /// </summary>
    /// <param name="root">The root node of the binary tree whose nodes collectively hold as many coins as nodes.</param>
    /// <returns>The minimum number of moves required to distribute the coins evenly.</returns>
    int DistributeCoins(TreeNode? root);
}