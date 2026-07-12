// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public interface IMergeTwoSortedLists
{
    /// <summary>
    ///     Merges the two sorted linked lists <paramref name="list1" /> and <paramref name="list2" /> into a single
    ///     sorted linked list.
    /// </summary>
    /// <param name="list1">The head of the first sorted linked list.</param>
    /// <param name="list2">The head of the second sorted linked list.</param>
    /// <returns>The head of the merged sorted linked list.</returns>
    ListNode? MergeTwoLists(ListNode? list1, ListNode? list2);
}