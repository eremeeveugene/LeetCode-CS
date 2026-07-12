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

namespace LeetCode.Algorithms.FindBottomLeftTreeValue;

/// <summary>
///     https://leetcode.com/problems/find-bottom-left-tree-value/
/// </summary>
public interface IFindBottomLeftTreeValue
{
    /// <summary>
    ///     Finds the value of the leftmost node in the last row of the binary tree rooted at <paramref name="root" />.
    /// </summary>
    /// <param name="root">The root node of the binary tree.</param>
    /// <returns>The value of the leftmost node in the deepest level of the tree.</returns>
    int FindBottomLeftValue(TreeNode? root);
}