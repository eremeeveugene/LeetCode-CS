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

/// <inheritdoc />
public sealed class LinkedListCycle2TwoPointers : ILinkedListCycle2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public ListNode? DetectCycle(ListNode? head)
    {
        if (head == null)
        {
            return null;
        }

        var slow = head.next;
        var fast = head.next?.next;

        while (fast is { next: not null } && slow != fast)
        {
            slow = slow!.next;
            fast = fast.next.next;
        }

        if (fast?.next == null)
        {
            return null;
        }

        slow = head;

        while (slow != fast)
        {
            slow = slow!.next;
            fast = fast!.next;
        }

        return fast;
    }
}