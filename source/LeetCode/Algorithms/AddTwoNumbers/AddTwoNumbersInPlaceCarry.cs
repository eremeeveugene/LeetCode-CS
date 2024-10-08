﻿// --------------------------------------------------------------------------------
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

namespace LeetCode.Algorithms.AddTwoNumbers;

/// <inheritdoc />
public class AddTwoNumbersInPlaceCarry : IAddTwoNumbers
{
    /// <summary>
    ///     Time complexity - O(n + m), where n is the length of the list l1 and m is the length of the list l2
    ///     Space complexity - O(max(n, m)), where n is the length of the list l1 and m is the length of the list l2
    /// </summary>
    /// <param name="l1"></param>
    /// <param name="l2"></param>
    /// <returns></returns>
    public ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        var carry = 0;

        ListNode? head = null;

        while (l1 != null || l2 != null)
        {
            var val1 = l1?.val ?? 0;
            var val2 = l2?.val ?? 0;

            var sum = val1 + val2 + carry;

            carry = 0;

            if (sum >= 10)
            {
                carry = 1;
                sum -= 10;
            }

            l1 = l1?.next;
            l2 = l2?.next;

            head = new ListNode(sum, head);
        }

        if (carry > 0)
        {
            head = new ListNode(1, head);
        }

        return Reverse(head);
    }

    private static ListNode? Reverse(ListNode? head)
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