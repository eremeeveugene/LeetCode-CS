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

namespace LeetCode.Algorithms.DeleteNodesAndReturnForest;

/// <summary>
///     https://leetcode.com/problems/delete-nodes-and-return-forest/
/// </summary>
public interface IDeleteNodesAndReturnForest
{
    /// <summary>
    ///     Deletes every node whose value is in <paramref name="toDelete" /> from the binary tree rooted at
    ///     <paramref name="root" />, splitting the tree into a forest of disjoint trees.
    /// </summary>
    /// <param name="root">The root of the binary tree with distinct node values.</param>
    /// <param name="toDelete">The values of the nodes to delete.</param>
    /// <returns>The roots of the trees in the resulting forest.</returns>
    IList<TreeNode> DelNodes(TreeNode? root, int[] toDelete);
}