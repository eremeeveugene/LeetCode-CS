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

namespace LeetCode.Algorithms.RemoveNthNodeFromEndOfList;

/// <summary>
///     https://leetcode.com/problems/remove-nth-node-from-end-of-list/description/
/// </summary>
public interface IRemoveNthNodeFromEndOfList
{
    /// <summary>
    ///     Removes the <paramref name="n" />-th node from the end of the linked list starting at <paramref name="head" />.
    /// </summary>
    /// <param name="head">The head of the linked list.</param>
    /// <param name="n">The 1-based position from the end of the node to remove.</param>
    /// <returns>The head of the linked list after the node has been removed.</returns>
    ListNode? RemoveNthFromEnd(ListNode? head, int n);
}