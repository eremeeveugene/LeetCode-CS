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

namespace LeetCode.Algorithms.DoubleNumberRepresentedAsLinkedList;

/// <summary>
///     https://leetcode.com/problems/double-a-number-represented-as-a-linked-list/
/// </summary>
public interface IDoubleNumberRepresentedAsLinkedList
{
    /// <summary>
    ///     Doubles the non-negative integer represented by the linked list starting at <paramref name="head" />.
    /// </summary>
    /// <param name="head">The head node of the singly linked list representing the number to double.</param>
    /// <returns>The head node of the linked list representing the doubled number.</returns>
    ListNode? DoubleIt(ListNode? head);
}