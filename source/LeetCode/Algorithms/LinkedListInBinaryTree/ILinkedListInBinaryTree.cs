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

namespace LeetCode.Algorithms.LinkedListInBinaryTree;

/// <summary>
///     https://leetcode.com/problems/linked-list-in-binary-tree/
/// </summary>
public interface ILinkedListInBinaryTree
{
    /// <summary>
    ///     Determines whether the linked list starting at <paramref name="head" /> matches a downward root-to-leaf-or-partial path in the binary tree rooted
    ///     at <paramref name="root" />.
    /// </summary>
    /// <param name="head">The head node of the linked list to match against a path.</param>
    /// <param name="root">The root node of the binary tree to search.</param>
    /// <returns><see langword="true" /> if the linked list corresponds to a downward path in the tree; otherwise, <see langword="false" />.</returns>
    bool IsSubPath(ListNode head, TreeNode root);
}