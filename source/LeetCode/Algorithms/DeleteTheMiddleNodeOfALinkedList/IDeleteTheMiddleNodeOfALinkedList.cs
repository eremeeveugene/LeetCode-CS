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

namespace LeetCode.Algorithms.DeleteTheMiddleNodeOfALinkedList;

/// <summary>
///     https://leetcode.com/problems/delete-the-middle-node-of-a-linked-list/description/
/// </summary>
public interface IDeleteTheMiddleNodeOfALinkedList
{
    /// <summary>
    ///     Deletes the middle node of the linked list, where the middle node of a list of size <c>n</c> is the
    ///     <c>⌊n / 2⌋</c>th node from the start using 0-based indexing.
    /// </summary>
    /// <param name="head">The head of a linked list.</param>
    /// <returns>The head of the modified linked list, or <c>null</c> when the list becomes empty.</returns>
    ListNode? DeleteMiddle(ListNode head);
}