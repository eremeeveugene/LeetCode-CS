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

namespace LeetCode.Algorithms.ReverseLinkedList;

/// <inheritdoc />
public sealed class ReverseLinkedListIterative : IReverseLinkedList
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public ListNode? ReverseList(ListNode? head)
    {
        ListNode? reverseHead = null;

        while (head != null)
        {
            reverseHead = new ListNode(head.val, reverseHead);

            head = head.next;
        }

        return reverseHead;
    }
}