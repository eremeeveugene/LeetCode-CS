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

namespace LeetCode.Algorithms.ReorderList;

/// <inheritdoc />
public sealed class ReorderListTwoPointers : IReorderList
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public void ReorderList(ListNode? head)
    {
        if (head!.next == null)
        {
            return;
        }

        var slow = head;
        var fast = head;

        while (fast.next is { next: not null })
        {
            slow = slow!.next;
            fast = fast.next.next;
        }

        var stack = new Stack<ListNode>();

        var current = slow!.next;

        while (current != null)
        {
            stack.Push(current);

            current = current.next;
        }

        slow.next = null;

        var left = head;

        while (left != null && stack.Count > 0)
        {
            var poppedNode = stack.Pop();

            var temp = left.next;

            left.next = poppedNode;
            poppedNode.next = temp;

            left = temp;
        }
    }
}