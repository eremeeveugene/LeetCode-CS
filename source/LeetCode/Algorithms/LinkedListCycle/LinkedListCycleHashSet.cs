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
public class LinkedListCycleHashSet : ILinkedListCycle
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public bool HasCycle(ListNode? head)
    {
        if (head?.next == null)
        {
            return false;
        }

        var ht = new HashSet<ListNode>();

        while (head != null)
        {
            if (!ht.Add(head))
            {
                return true;
            }

            head = head.next;
        }

        return false;
    }
}