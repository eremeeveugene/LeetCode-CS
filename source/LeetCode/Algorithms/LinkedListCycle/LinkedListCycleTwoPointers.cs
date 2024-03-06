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

namespace LeetCode.Algorithms.LinkedListCycle;

/// <inheritdoc />
public class LinkedListCycleTwoPointers : ILinkedListCycle
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public bool HasCycle(ListNode? head)
    {
        if (head == null)
        {
            return false;
        }

        var slow = head;
        var fast = head.next;

        while (fast is { next: not null })
        {
            if (slow == fast)
            {
                return true;
            }

            slow = slow?.next;
            fast = fast.next.next;
        }

        return false;
    }
}