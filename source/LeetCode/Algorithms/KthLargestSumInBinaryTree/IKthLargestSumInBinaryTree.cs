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

namespace LeetCode.Algorithms.KthLargestSumInBinaryTree;

/// <summary>
///     https://leetcode.com/problems/kth-largest-sum-in-a-binary-tree/description/
/// </summary>
public interface IKthLargestSumInBinaryTree
{
    /// <summary>
    ///     Finds the <paramref name="k" />-th largest level sum in the binary tree rooted at <paramref name="root" />.
    /// </summary>
    /// <param name="root">The root of the binary tree.</param>
    /// <param name="k">The 1-based rank of the level sum to find.</param>
    /// <returns>The <paramref name="k" />-th largest level sum, or -1 if the tree has fewer than <paramref name="k" /> levels.</returns>
    long KthLargestLevelSum(TreeNode root, int k);
}