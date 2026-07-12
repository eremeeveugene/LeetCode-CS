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

namespace LeetCode.Algorithms.RemoveDuplicatesFromSortedList;

/// <inheritdoc />
public sealed class RemoveDuplicatesFromSortedListIterativeReverse : IRemoveDuplicatesFromSortedList
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public ListNode? DeleteDuplicates(ListNode? head)
    {
        ListNode? result = null;

        while (head != null)
        {
            if (result?.val != head.val)
            {
                result = new ListNode(head.val, result);
            }

            head = head.next;
        }

        return Reverse(result);
    }

    public static ListNode? Reverse(ListNode? head)
    {
        ListNode? prev = null;
        var current = head;

        while (current != null)
        {
            var next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }
}