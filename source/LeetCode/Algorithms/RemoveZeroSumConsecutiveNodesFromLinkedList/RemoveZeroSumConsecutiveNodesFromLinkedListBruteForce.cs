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

namespace LeetCode.Algorithms.RemoveZeroSumConsecutiveNodesFromLinkedList;

/// <inheritdoc />
public class RemoveZeroSumConsecutiveNodesFromLinkedListBruteForce : IRemoveZeroSumConsecutiveNodesFromLinkedList
{
    /// <summary>
    ///     Time complexity - O(n^3)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public ListNode? RemoveZeroSumSublists(ListNode? head)
    {
        if (head == null)
        {
            return null;
        }

        var values = new List<int>();

        while (head != null)
        {
            values.Add(head.val);

            head = head.next;
        }

        var i = 0;

        while (i < values.Count)
        {
            for (var j = i; j >= 0; j--)
            {
                var sum = 0;

                for (var k = j; k <= i; k++)
                {
                    sum += values[k];
                }

                if (sum != 0)
                {
                    continue;
                }

                values.RemoveRange(j, i - j + 1);

                i -= i - j + 1;

                break;
            }

            i++;
        }

        if (values.Count == 0)
        {
            return null;
        }

        var dummyHead = new ListNode();

        var current = dummyHead;

        foreach (var value in values)
        {
            current.next = new ListNode(value);
            current = current.next;
        }

        return dummyHead.next;
    }
}