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

// ReSharper disable InconsistentNaming

#pragma warning disable S1104

using LeetCode.Core.Exceptions;

namespace LeetCode.Core.Models;

/// <summary>
///     Definition for singly-linked list
/// </summary>
public sealed class ListNode
{
    public ListNode? next;

    public int val;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.next = next;
        this.val = val;
    }

    public static ListNode ToListNodeOrThrow(int[] array)
    {
        return ToListNode(array) ?? throw new ListNodeBuildException();
    }

    public static ListNode? ToListNode(int[] array)
    {
        return array.Reverse().Aggregate<int, ListNode?>(null, (next, val) => new ListNode(val, next));
    }

    /// <summary>
    ///     Builds a linked list with an optional cycle and returns the node at the specified distance from its head.
    /// </summary>
    /// <remarks>
    ///     The returned node belongs to the same list as the returned head.
    ///     Traversal follows the cycle when the distance extends beyond the original array.
    /// </remarks>
    /// <param name="array">The node values in list order.</param>
    /// <param name="cyclePosition">The index connected to the tail, or a negative value for no cycle.</param>
    /// <param name="distance">The number of next links to follow from the head, or a negative value for null.</param>
    /// <param name="node">The node at the requested distance, or null if the distance is negative or the list ends.</param>
    /// <returns>The head of the constructed list, or null for an empty array.</returns>
    public static ListNode? ToCycledListNode(int[] array, int cyclePosition, int distance, out ListNode? node)
    {
        var head = ToCycledListNode(array, cyclePosition);

        node = distance < 0 ? null : head;

        for (var i = 0; i < distance; i++)
        {
            node = node?.next;
        }

        return head;
    }

    public static ListNode? ToCycledListNode(int[] array, int cyclePosition)
    {
        var head = ToListNode(array);

        if (head == null || cyclePosition < 0)
        {
            return head;
        }

        ListNode? lastNode = head, cycleNode = null;

        var index = 0;

        while (lastNode.next != null)
        {
            if (index == cyclePosition)
            {
                cycleNode = lastNode;
            }

            lastNode = lastNode.next;

            index++;
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