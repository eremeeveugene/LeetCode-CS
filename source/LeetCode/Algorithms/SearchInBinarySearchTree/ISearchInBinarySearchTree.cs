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

namespace LeetCode.Algorithms.SearchInBinarySearchTree;

/// <summary>
///     https://leetcode.com/problems/search-in-a-binary-search-tree/description/
/// </summary>
public interface ISearchInBinarySearchTree
{
    /// <summary>
    ///     Searches the binary search tree rooted at <paramref name="root" /> for the node whose value equals
    ///     <paramref name="val" />.
    /// </summary>
    /// <param name="root">The root of the binary search tree.</param>
    /// <param name="val">The value to search for.</param>
    /// <returns>The subtree rooted at the node with value <paramref name="val" />, or <see langword="null" /> if not found.</returns>
    TreeNode? SearchBST(TreeNode? root, int val);
}