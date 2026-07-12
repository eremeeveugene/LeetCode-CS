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

namespace LeetCode.Algorithms.FindModeInBinarySearchTree;

/// <summary>
///     https://leetcode.com/problems/find-mode-in-binary-search-tree/
/// </summary>
public interface IFindModeInBinarySearchTree
{
    /// <summary>
    ///     Finds the mode(s), the most frequently occurring values, in the binary search tree rooted at
    ///     <paramref name="root" />.
    /// </summary>
    /// <param name="root">The root of the binary search tree.</param>
    /// <returns>The array of the most frequently occurring values in the tree.</returns>
    int[] FindMode(TreeNode? root);
}