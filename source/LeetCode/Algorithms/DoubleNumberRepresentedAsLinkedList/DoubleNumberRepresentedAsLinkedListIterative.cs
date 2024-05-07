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

namespace LeetCode.Algorithms.DoubleNumberRepresentedAsLinkedList;

/// <inheritdoc />
public class DoubleNumberRepresentedAsLinkedListIterative : IDoubleNumberRepresentedAsLinkedList
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public ListNode? DoubleIt(ListNode? head)
    {
        ListNode? previous = null;

        var current = head;

        while (current != null)
        {
            var next = current.next;

            current.next = previous;
            previous = current;
            current = next;
        }

        var reversedHead = previous;

        var node = reversedHead;
        var carry = 0;

        ListNode? lastNode = null;

        while (node != null)
        {
            var newVal = (node.val * 2) + carry;

            if (newVal > 9)
            {
                carry = 1;

                newVal %= 10;
            }
            else
            {
                carry = 0;
            }

            node.val = newVal;
            lastNode = node;
            node = node.next;
        }

        if (lastNode != null && carry > 0)
        {
            lastNode.next = new ListNode(carry);
        }

        previous = null;
        current = reversedHead;

        while (current != null)
        {
            var next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }

        return previous;
    }
}