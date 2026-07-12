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

namespace LeetCode.Algorithms.NumberOfGoodLeafNodesPairs;

/// <summary>
///     https://leetcode.com/problems/number-of-good-leaf-nodes-pairs/description/
/// </summary>
public interface INumberOfGoodLeafNodesPairs
{
    /// <summary>
    ///     Counts the number of good leaf node pairs in the binary tree rooted at <paramref name="root" />, where a
    ///     pair of leaf nodes is good if the shortest path between them is less than or equal to
    ///     <paramref name="distance" />.
    /// </summary>
    /// <param name="root">The root node of the binary tree, or <see langword="null" /> for an empty tree.</param>
    /// <param name="distance">The maximum allowed path length between two leaf nodes for the pair to count as good.</param>
    /// <returns>The number of good leaf node pairs in the tree.</returns>
    int CountPairs(TreeNode? root, int distance);
}