// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Core.Models;

namespace LeetCode.Algorithms.RemoveNodesFromLinkedList;

/// <inheritdoc />
public class RemoveNodesFromLinkedListIterative : IRemoveNodesFromLinkedList
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public ListNode? RemoveNodes(ListNode? head)
    {
        head = Reverse(head);

        var dummyHead = new ListNode();
        var tail = dummyHead;
        var maxValue = int.MinValue;

        while (head != null)
        {
            if (head.val >= maxValue)
            {
                maxValue = head.val;
                tail.next = head;
                tail = head;
            }

            head = head.next;
        }

        tail.next = null;

        return Reverse(dummyHead.next);
    }

    private static ListNode? Reverse(ListNode? head)
    {
        ListNode? prev = null;

        var curr = head;

        while (curr != null)
        {
            var next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        return prev;
    }
}