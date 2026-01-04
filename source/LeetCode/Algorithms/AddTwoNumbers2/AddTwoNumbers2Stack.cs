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
public class AddTwoNumbers2Stack : IAddTwoNumbers2
{
    /// <summary>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(n + m)
    /// </summary>
    /// <param name="l1"></param>
    /// <param name="l2"></param>
    /// <returns></returns>
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var l1Stack = new Stack<int>();
        var l1Node = l1;

        while (l1Node != null)
        {
            l1Stack.Push(l1Node.val);

            l1Node = l1Node.next;
        }

        var l2Stack = new Stack<int>();
        var l2Node = l2;

        while (l2Node != null)
        {
            l2Stack.Push(l2Node.val);

            l2Node = l2Node.next;
        }

        ListNode? resultNode = null;
        var remainder = 0;

        while (l1Stack.Count > 0 || l2Stack.Count > 0 || remainder > 0)
        {
            var node1 = l1Stack.Count > 0 ? l1Stack.Pop() : 0;
            var node2 = l2Stack.Count > 0 ? l2Stack.Pop() : 0;

            var value = node1 + node2 + remainder;

            if (value > 9)
            {
                remainder = 1;
                value -= 10;
            }
            else
            {
                remainder = 0;
            }

            resultNode = new ListNode(value, resultNode);
        }

        return resultNode!;
    }
}