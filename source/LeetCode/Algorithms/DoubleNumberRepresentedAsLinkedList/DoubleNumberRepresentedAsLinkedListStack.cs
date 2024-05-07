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
public class DoubleNumberRepresentedAsLinkedListStack : IDoubleNumberRepresentedAsLinkedList
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public ListNode? DoubleIt(ListNode? head)
    {
        var stack = new Stack<ListNode>();

        while (head != null)
        {
            stack.Push(head);

            head = head.next;
        }

        var dummyHead = new ListNode();

        var carry = 0;

        while (stack.Count > 0)
        {
            var current = stack.Pop();

            var newVal = (current.val * 2) + carry;

            if (newVal > 9)
            {
                carry = 1;

                newVal %= 10;
            }
            else
            {
                carry = 0;
            }

            current.val = newVal;
            current.next = dummyHead.next;

            dummyHead.next = current;
        }

        if (carry > 0)
        {
            dummyHead.next = new ListNode(1, dummyHead.next);
        }

        return dummyHead.next;
    }
}