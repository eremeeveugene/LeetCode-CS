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

namespace LeetCode.Algorithms.BinaryTreePaths;

/// <summary>
///     https://leetcode.com/problems/binary-tree-paths/
/// </summary>
public interface IBinaryTreePaths
{
    /// <summary>
    ///     Returns all root-to-leaf paths of the binary tree rooted at <paramref name="root" /> in the format
    ///     "value1-&gt;value2-&gt;...".
    /// </summary>
    /// <param name="root">The root of the binary tree.</param>
    /// <returns>All root-to-leaf paths in any order.</returns>
    IList<string> BinaryTreePaths(TreeNode? root);
}