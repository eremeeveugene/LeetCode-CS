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

namespace LeetCode.Algorithms.RemoveNodesFromLinkedList;

/// <summary>
///     https://leetcode.com/problems/remove-nodes-from-linked-list/
/// </summary>
public interface IRemoveNodesFromLinkedList
{
    /// <summary>
    ///     Removes every node in the linked list starting at <paramref name="head" /> that has a strictly greater node
    ///     somewhere to its right.
    /// </summary>
    /// <param name="head">The head of the linked list.</param>
    /// <returns>The head of the linked list after the disqualifying nodes have been removed.</returns>
    ListNode? RemoveNodes(ListNode? head);
}