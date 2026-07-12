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

namespace LeetCode.Algorithms.DeleteLeavesWithGivenValue;

/// <summary>
///     https://leetcode.com/problems/delete-leaves-with-a-given-value/
/// </summary>
public interface IDeleteLeavesWithGivenValue
{
    /// <summary>
    ///     Deletes every leaf node with value <paramref name="target" /> from the binary tree rooted at
    ///     <paramref name="root" />, repeating the process for nodes that become leaves after the deletions.
    /// </summary>
    /// <param name="root">The root of the binary tree.</param>
    /// <param name="target">The value of the leaf nodes to delete.</param>
    /// <returns>The root of the resulting tree, or <c>null</c> if the whole tree is deleted.</returns>
    TreeNode? RemoveLeafNodes(TreeNode? root, int target);
}