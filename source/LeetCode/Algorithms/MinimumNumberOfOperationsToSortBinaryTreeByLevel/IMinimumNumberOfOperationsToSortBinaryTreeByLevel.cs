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

namespace LeetCode.Algorithms.MinimumNumberOfOperationsToSortBinaryTreeByLevel;

/// <summary>
///     https://leetcode.com/problems/minimum-number-of-operations-to-sort-a-binary-tree-by-level/description/
/// </summary>
public interface IMinimumNumberOfOperationsToSortBinaryTreeByLevel
{
    /// <summary>
    ///     Finds the minimum total number of swaps of adjacent nodes, performed level by level, required to sort
    ///     the values at every level of the binary tree rooted at <paramref name="root" /> in increasing order.
    /// </summary>
    /// <param name="root">The root of the binary tree, whose node values are distinct.</param>
    /// <returns>The minimum total number of swaps required.</returns>
    int MinimumOperations(TreeNode root);
}