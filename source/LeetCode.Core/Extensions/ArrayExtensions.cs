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

namespace LeetCode.Core.Extensions;

public static class ArrayExtensions
{
    public static ListNode? ToListNode(this int[] array)
    {
        return array.Reverse().Aggregate<int, ListNode?>(null, (next, val) => new ListNode(val, next));
    }

    public static ListNode? ToCycledListNode(this int[] array, int cyclePosition)
    {
        var head = array.ToListNode();

        if (head == null || cyclePosition < 0)
        {
            return head;
        }

        ListNode? lastNode = head, cycleNode = null;

        for (var index = 0; lastNode.next != null; index++)
        {
            if (index == cyclePosition)
            {
                cycleNode = lastNode;
            }

            lastNode = lastNode.next;
        }

        if (cyclePosition == array.Length - 1)
        {
            cycleNode = lastNode;
        }

        if (cycleNode != null)
        {
            lastNode.next = cycleNode;
        }

        return head;
    }
}