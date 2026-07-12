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

namespace LeetCode.Algorithms.InsertGreatestCommonDivisorsInLinkedList;

/// <summary>
///     https://leetcode.com/problems/insert-greatest-common-divisors-in-linked-list/
/// </summary>
public interface IInsertGreatestCommonDivisorsInLinkedList
{
    /// <summary>
    ///     Inserts between every pair of adjacent nodes of the linked list starting at <paramref name="head" /> a new node
    ///     whose value is the greatest common divisor of the two adjacent values.
    /// </summary>
    /// <param name="head">The head of the linked list.</param>
    /// <returns>The head of the linked list after the insertions.</returns>
    ListNode? InsertGreatestCommonDivisors(ListNode head);
}