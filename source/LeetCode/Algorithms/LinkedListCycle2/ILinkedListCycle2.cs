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

namespace LeetCode.Algorithms.LinkedListCycle2;

/// <summary>
///     https://leetcode.com/problems/linked-list-cycle-ii/description/
/// </summary>
public interface ILinkedListCycle2
{
    /// <summary>
    ///     Finds the node where a cycle begins without modifying the linked list.
    /// </summary>
    /// <param name="head">The head of the linked list, or null for an empty list.</param>
    /// <returns>The cycle-entry node, or null if the list has no cycle.</returns>
    ListNode? DetectCycle(ListNode? head);
}