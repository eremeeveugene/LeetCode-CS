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

namespace LeetCode.Algorithms.AddTwoNumbers2;

/// <inheritdoc />
public sealed class AddTwoNumbers2Reverse : IAddTwoNumbers2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(n + m)
    /// </remarks>
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var dummyNode = new ListNode();
        var node = dummyNode;

        var l1Node = Reverse(l1);
        var l2Node = Reverse(l2);

        var remainder = 0;

        while (l1Node != null || l2Node != null || remainder > 0)
        {
            var value = remainder;

            if (l1Node != null)
            {
                value += l1Node.val;

                l1Node = l1Node.next;
            }

            if (l2Node != null)
            {
                value += l2Node.val;

                l2Node = l2Node.next;
            }

            if (value > 9)
            {
                remainder = 1;
                value -= 10;
            }
            else
            {
                remainder = 0;
            }

            node.next = new ListNode(value);
            node = node.next;
        }

        return Reverse(dummyNode.next);
    }

    private static ListNode Reverse(ListNode? node)
    {
        ListNode? prev = null;

        while (node != null)
        {
            var next = node.next;
            node.next = prev;
            prev = node;
            node = next;
        }

        return prev!;
    }
}