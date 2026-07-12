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

namespace LeetCode.Algorithms.DeleteNodeFromLinkedListPresentInArray;

/// <summary>
///     https://leetcode.com/problems/delete-nodes-from-linked-list-present-in-array/description/
/// </summary>
public interface IDeleteNodeFromLinkedListPresentInArray
{
    /// <summary>
    ///     Removes from the linked list starting at <paramref name="head" /> every node whose value is present in
    ///     <paramref name="nums" />.
    /// </summary>
    /// <param name="nums">The array of values to remove from the linked list.</param>
    /// <param name="head">The head of the linked list.</param>
    /// <returns>The head of the modified linked list, or <c>null</c> if all nodes are removed.</returns>
    ListNode? ModifiedList(int[] nums, ListNode? head);
}