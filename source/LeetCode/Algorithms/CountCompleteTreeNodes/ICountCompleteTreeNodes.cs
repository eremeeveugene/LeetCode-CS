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

namespace LeetCode.Algorithms.CountCompleteTreeNodes;

/// <summary>
///     https://leetcode.com/problems/count-complete-tree-nodes/
/// </summary>
public interface ICountCompleteTreeNodes
{
    /// <summary>
    ///     Counts the number of nodes in the complete binary tree rooted at <paramref name="root" />.
    /// </summary>
    /// <param name="root">The root node of the complete binary tree.</param>
    /// <returns>The total number of nodes in the tree.</returns>
    int CountNodes(TreeNode? root);
}