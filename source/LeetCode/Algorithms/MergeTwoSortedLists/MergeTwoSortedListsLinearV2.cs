﻿// --------------------------------------------------------------------------------
// Copyright (C) 2023 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

#region

using LeetCode.Core.Models;

#endregion

namespace LeetCode.Algorithms.MergeTwoSortedLists;

/// <summary>
///     Merge Two Sorted Lists
///     https://leetcode.com/problems/merge-two-sorted-lists/
///     You are given the heads of two sorted linked lists list1 and list2.
///     Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two
///     lists.
///     Return the head of the merged linked list.
///     Example 1:
///     Input: list1 = [1,2,4], list2 = [1,3,4]
///     Output: [1,1,2,3,4,4]
///     Example 2:
///     Input: list1 = [], list2 = []
///     Output: []
///     Example 3:
///     Input: list1 = [], list2 = [0]
///     Output: [0]
///     Constraints:
///     The number of nodes in both lists is in the range [0, 50].
///     -100 less than or equal to Node.val less than or equal to 100
///     Both list1 and list2 are sorted in non-decreasing order.
/// </summary>
public static class MergeTwoSortedListsLinearV2
{
    /// <summary>
    ///     Time complexity - O (n + m)
    /// </summary>
    /// <param name="list1"></param>
    /// <param name="list2"></param>
    /// <returns></returns>
    public static ListNode? GetResult(ListNode? list1, ListNode? list2)
    {
        if (list1 == null) return list2;
        if (list2 == null) return list1;

        var dummyHead = new ListNode();
        var current = dummyHead;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }

            current = current.next;
        }

        current.next = list1 ?? list2;

        return dummyHead.next;
    }
}