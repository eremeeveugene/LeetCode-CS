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

namespace LeetCode.Algorithms.RemoveNthNodeFromEndOfList;

/// <inheritdoc />
public class RemoveNthNodeFromEndOfListTwoPointers : IRemoveNthNodeFromEndOfList
{
    /// <summary>
    ///     Time complexity - O(n), where n is the  number of nodes in the linked list
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="head"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public ListNode? RemoveNthFromEnd(ListNode? head, int n)
    {
        var dummyHead = new ListNode { next = head };

        var slowPointer = dummyHead;
        var fastPointer = dummyHead;

        for (var i = 0; i <= n; i++)
        {
            fastPointer = fastPointer?.next;
        }

        while (fastPointer != null)
        {
            slowPointer = slowPointer?.next;
            fastPointer = fastPointer.next;
        }

        if (slowPointer != null)
        {
            slowPointer.next = slowPointer.next?.next;
        }

        return dummyHead.next;
    }
}