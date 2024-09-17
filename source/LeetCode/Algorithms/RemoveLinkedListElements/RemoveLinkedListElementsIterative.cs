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

namespace LeetCode.Algorithms.RemoveLinkedListElements;

/// <inheritdoc />
public class RemoveLinkedListElementsIterative : IRemoveLinkedListElements
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="head"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public ListNode? RemoveElements(ListNode? head, int val)
    {
        if (head == null)
        {
            return null;
        }

        var dummyHead = new ListNode(next: head);
        var current = dummyHead;

        while (current.next != null)
        {
            if (current.next.val == val)
            {
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }

        return dummyHead.next;
    }
}