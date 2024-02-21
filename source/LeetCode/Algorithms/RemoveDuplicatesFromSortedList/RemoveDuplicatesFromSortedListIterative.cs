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

namespace LeetCode.Algorithms.RemoveDuplicatesFromSortedList;

/// <inheritdoc />
public class RemoveDuplicatesFromSortedListIterative : IRemoveDuplicatesFromSortedList
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public ListNode? DeleteDuplicates(ListNode? head)
    {
        var dummyHead = new ListNode(int.MinValue);
        var current = dummyHead;

        while (head != null)
        {
            if (current.val != head.val)
            {
                current.next = head;
                current = head;
            }

            head = head.next;
        }

        current.next = null;

        return dummyHead.next;
    }
}