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

namespace LeetCode.Algorithms.RemoveLinkedListElements;

/// <summary>
///     https://leetcode.com/problems/remove-linked-list-elements/description/
/// </summary>
public interface IRemoveLinkedListElements
{
    /// <summary>
    ///     Removes all nodes with value <paramref name="val" /> from the linked list starting at <paramref name="head" />.
    /// </summary>
    /// <param name="head">The head of the linked list.</param>
    /// <param name="val">The value to remove from the linked list.</param>
    /// <returns>The head of the linked list after nodes with value <paramref name="val" /> have been removed.</returns>
    ListNode? RemoveElements(ListNode? head, int val);
}