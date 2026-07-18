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

namespace LeetCode.Algorithms.DeleteNodeInLinkedList;

/// <summary>
///     https://leetcode.com/problems/delete-node-in-a-linked-list/description
/// </summary>
public interface IDeleteNodeInLinkedList
{
    /// <summary>
    ///     Deletes <paramref name="node" /> from the linked list it belongs to, given access to that node only and not
    ///     to the head of the list.
    /// </summary>
    /// <param name="node">The non-tail node to delete from the linked list.</param>
    void DeleteNode(ListNode node);
}