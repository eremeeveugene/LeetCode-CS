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

/// <inheritdoc />
public sealed class DeleteTheMiddleNodeOfALinkedListTwoPointers : IDeleteTheMiddleNodeOfALinkedList
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public ListNode? DeleteMiddle(ListNode head)
    {
        if (head.next == null)
        {
            return null;
        }

        var slow = head;
        var fast = head.next.next;

        while (fast?.next != null)
        {
            slow = slow?.next;
            fast = fast.next.next;
        }

        slow?.next = slow.next?.next;

        return head;
    }
}