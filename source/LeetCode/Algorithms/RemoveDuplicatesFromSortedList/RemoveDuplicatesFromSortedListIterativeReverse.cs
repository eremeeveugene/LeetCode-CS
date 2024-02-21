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
public class RemoveDuplicatesFromSortedListIterativeReverse : IRemoveDuplicatesFromSortedList
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public ListNode? DeleteDuplicates(ListNode? head)
    {
        ListNode? result = null;

        while (head != null)
        {
            if (result?.val != head.val)
            {
                result = new ListNode(head.val, result);
            }

            head = head.next;
        }

        return ListNode.Reverse(result);
    }
}