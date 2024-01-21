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

namespace LeetCode.Core.Models;

/// <summary>
///     Definition for singly-linked list
/// </summary>
public class ListNode(int val = 0, ListNode? next = null)
{
    // ReSharper disable once InconsistentNaming
    public ListNode? next = next;

    // ReSharper disable once InconsistentNaming
    public int val = val;

    public static ListNode? Reverse(ListNode? head)
    {
        ListNode? prev = null;
        var current = head;

        while (current != null)
        {
            var next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }
}