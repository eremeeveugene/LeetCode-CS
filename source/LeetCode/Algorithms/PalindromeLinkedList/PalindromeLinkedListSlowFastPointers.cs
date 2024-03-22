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

namespace LeetCode.Algorithms.PalindromeLinkedList;

/// <inheritdoc />
public class PalindromeLinkedListSlowFastPointers : IPalindromeLinkedList
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public bool IsPalindrome(ListNode? head)
    {
        if (head?.next == null)
        {
            return true;
        }

        var slow = head;
        var fast = head;

        while (fast.next is { next: not null })
        {
            slow = slow?.next;
            fast = fast.next.next;
        }


        var secondHalfStart = ReverseList(slow?.next);

        var firstHalfStart = head;

        while (secondHalfStart != null)
        {
            if (firstHalfStart != null && firstHalfStart.val != secondHalfStart.val)
            {
                return false;
            }

            firstHalfStart = firstHalfStart?.next;
            secondHalfStart = secondHalfStart.next;
        }

        return true;
    }

    private static ListNode? ReverseList(ListNode? head)
    {
        ListNode? reverseHead = null;

        while (head != null)
        {
            var nextTemp = head.next;
            head.next = reverseHead;
            reverseHead = head;
            head = nextTemp;
        }

        return reverseHead;
    }
}