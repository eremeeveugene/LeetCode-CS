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

using LeetCode.Core.Models;

namespace LeetCode.Algorithms.MergeTwoSortedLists;

/// <summary>
///     https://leetcode.com/problems/merge-two-sorted-lists/
/// </summary>
public static class MergeTwoSortedListsLinear
{
    /// <summary>
    ///     Time complexity - O (n + m)
    /// </summary>
    /// <param name="list1"></param>
    /// <param name="list2"></param>
    /// <returns></returns>
    public static ListNode? GetResult(ListNode? list1, ListNode? list2)
    {
        if (list1 == null && list2 == null)
        {
            return null;
        }

        if (list1 == null && list2 != null)
        {
            return list2;
        }

        if (list1 != null && list2 == null)
        {
            return list1;
        }

        if (list1 != null && list2 != null)
        {
            ListNode? headNode = null;

            ListNode? previousNode = null;

            while (list1 != null || list2 != null)
            {
                if (list1 == null && list2 != null)
                {
                    ListNode list2CurrentNode = new ListNode(list2.val);

                    if (previousNode != null)
                    {
                        previousNode.next = list2CurrentNode;
                    }

                    previousNode = list2CurrentNode;

                    headNode ??= list2CurrentNode;

                    list2 = list2.next;
                }
                else if (list1 != null && list2 == null)
                {
                    ListNode list1CurrentNode = new ListNode(list1.val);

                    if (previousNode != null)
                    {
                        previousNode.next = list1CurrentNode;
                    }

                    previousNode = list1CurrentNode;

                    headNode ??= list1CurrentNode;

                    list1 = list1.next;
                }

                else if (list2 != null && list1 != null)
                {
                    if (list1.val < list2.val)
                    {
                        ListNode list1CurrentNode = new ListNode(list1.val);

                        if (previousNode != null)
                        {
                            previousNode.next = list1CurrentNode;
                        }

                        previousNode = list1CurrentNode;

                        headNode ??= list1CurrentNode;

                        list1 = list1.next;
                    }
                    else
                    {
                        ListNode list2CurrentNode = new ListNode(list2.val);

                        if (previousNode != null)
                        {
                            previousNode.next = list2CurrentNode;
                        }

                        previousNode = list2CurrentNode;

                        headNode ??= list2CurrentNode;

                        list2 = list2.next;
                    }
                }
            }

            return headNode;
        }

        return null;
    }
}