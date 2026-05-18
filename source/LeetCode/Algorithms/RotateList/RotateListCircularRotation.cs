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

namespace LeetCode.Algorithms.RotateList;

/// <inheritdoc />
public sealed class RotateListCircularRotation : IRotateList
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public ListNode? RotateRight(ListNode? head, int k)
    {
        if (head == null)
        {
            return null;
        }

        if (head.next == null || k == 0)
        {
            return head;
        }

        var tail = head;
        var nodesCount = 1;

        while (tail.next != null)
        {
            tail = tail.next;

            nodesCount++;
        }

        k %= nodesCount;

        if (k == 0)
        {
            return head;
        }

        tail.next = head;

        var stepsToNewTail = nodesCount - k;

        while (stepsToNewTail > 0 && tail.next != null)
        {
            tail = tail.next;

            stepsToNewTail--;
        }

        head = tail.next;

        tail.next = null;

        return head;
    }
}