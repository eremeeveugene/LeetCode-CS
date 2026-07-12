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

namespace LeetCode.Algorithms.IntersectionOfTwoLinkedLists;

/// <summary>
///     https://leetcode.com/problems/intersection-of-two-linked-lists/
/// </summary>
public interface IIntersectionOfTwoLinkedLists
{
    /// <summary>
    ///     Finds the node at which the linked lists starting at <paramref name="headA" /> and <paramref name="headB" />
    ///     intersect.
    /// </summary>
    /// <param name="headA">The head of the first linked list.</param>
    /// <param name="headB">The head of the second linked list.</param>
    /// <returns>The node at which the two linked lists intersect, or <c>null</c> if they do not intersect.</returns>
    ListNode? GetIntersectionNode(ListNode? headA, ListNode? headB);
}