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

namespace LeetCode.Algorithms.BinaryTreePostorderTraversal;

/// <summary>
///     https://leetcode.com/problems/binary-tree-postorder-traversal/
/// </summary>
public interface IBinaryTreePostorderTraversal
{
    /// <summary>
    ///     Returns the postorder traversal of the values of the binary tree rooted at <paramref name="root" />.
    /// </summary>
    /// <param name="root">The root of the binary tree.</param>
    /// <returns>The node values in postorder order.</returns>
    IList<int> PostorderTraversal(TreeNode? root);
}