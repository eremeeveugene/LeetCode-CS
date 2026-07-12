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

namespace LeetCode.Algorithms.PathSum;

/// <summary>
///     https://leetcode.com/problems/path-sum/description/
/// </summary>
public interface IPathSum
{
    /// <summary>
    ///     Determines whether the binary tree rooted at <paramref name="root" /> has a root-to-leaf path whose node
    ///     values sum to <paramref name="targetSum" />.
    /// </summary>
    /// <param name="root">The root of the binary tree.</param>
    /// <param name="targetSum">The target sum to match along a root-to-leaf path.</param>
    /// <returns><see langword="true" /> if such a path exists; otherwise, <see langword="false" />.</returns>
    bool HasPathSum(TreeNode? root, int targetSum);
}