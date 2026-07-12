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

namespace LeetCode.Algorithms.MinimumDistanceBetweenBSTNodes;

/// <summary>
///     https://leetcode.com/problems/minimum-distance-between-bst-nodes/
/// </summary>
public interface IMinimumDistanceBetweenBSTNodes
{
    /// <summary>
    ///     Finds the minimum difference between the values of any two distinct nodes in the binary search tree
    ///     rooted at <paramref name="root" />.
    /// </summary>
    /// <param name="root">The root of the binary search tree.</param>
    /// <returns>The minimum difference between any two node values.</returns>
    int MinDiffInBST(TreeNode root);
}