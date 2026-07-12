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

namespace LeetCode.Algorithms.RemoveZeroSumConsecutiveNodesFromLinkedList;

/// <summary>
///     https://leetcode.com/problems/remove-zero-sum-consecutive-nodes-from-linked-list/
/// </summary>
public interface IRemoveZeroSumConsecutiveNodesFromLinkedList
{
    /// <summary>
    ///     Repeatedly removes consecutive sequences of nodes in the linked list starting at <paramref name="head" /> whose
    ///     values sum to zero until no such sequence remains.
    /// </summary>
    /// <param name="head">The head of the linked list.</param>
    /// <returns>The head of the linked list after all zero-sum consecutive sequences have been removed.</returns>
    ListNode? RemoveZeroSumSublists(ListNode? head);
}