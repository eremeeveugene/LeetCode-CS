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
public class PalindromeLinkedListTwoPointers : IPalindromeLinkedList
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public bool IsPalindrome(ListNode? head)
    {
        if (head?.next == null)
        {
            return true;
        }

        var values = new List<int>();

        while (head != null)
        {
            values.Add(head.val);

            head = head.next;
        }

        var left = 0;
        var right = values.Count - 1;

        while (left < right)
        {
            if (values[left] != values[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}