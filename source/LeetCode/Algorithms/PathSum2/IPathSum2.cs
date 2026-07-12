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

namespace LeetCode.Algorithms.PathSum2;

/// <summary>
///     https://leetcode.com/problems/path-sum-ii/description/
/// </summary>
public interface IPathSum2
{
    /// <summary>
    ///     Finds all root-to-leaf paths in the binary tree rooted at <paramref name="root" /> whose node values sum to
    ///     <paramref name="targetSum" />.
    /// </summary>
    /// <param name="root">The root of the binary tree.</param>
    /// <param name="targetSum">The target sum to match along a root-to-leaf path.</param>
    /// <returns>A list of all root-to-leaf paths whose values sum to <paramref name="targetSum" />.</returns>
    IList<IList<int>> PathSum(TreeNode? root, int targetSum);
}