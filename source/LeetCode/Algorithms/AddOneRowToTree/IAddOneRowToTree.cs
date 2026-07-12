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

namespace LeetCode.Algorithms.AddOneRowToTree;

/// <summary>
///     https://leetcode.com/problems/add-one-row-to-tree/
/// </summary>
public interface IAddOneRowToTree
{
    /// <summary>
    ///     Adds a row of nodes with value <paramref name="val" /> at the given <paramref name="depth" /> of the binary tree
    ///     rooted at <paramref name="root" />.
    /// </summary>
    /// <param name="root">The root of the binary tree.</param>
    /// <param name="val">The value of the new nodes to insert.</param>
    /// <param name="depth">The depth at which the new row is added.</param>
    /// <returns>The root of the modified binary tree.</returns>
    TreeNode? AddOneRow(TreeNode? root, int val, int depth);
}