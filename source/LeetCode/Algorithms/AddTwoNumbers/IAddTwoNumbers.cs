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

namespace LeetCode.Algorithms.AddTwoNumbers;

/// <summary>
///     https://leetcode.com/problems/add-two-numbers/
/// </summary>
public interface IAddTwoNumbers
{
    /// <summary>
    ///     Adds the two numbers represented by the linked lists <paramref name="l1" /> and <paramref name="l2" />, whose
    ///     digits are stored in reverse order, and returns the sum as a linked list.
    /// </summary>
    /// <param name="l1">The first linked list of digits in reverse order.</param>
    /// <param name="l2">The second linked list of digits in reverse order.</param>
    /// <returns>The head of a linked list representing the sum with digits in reverse order.</returns>
    ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2);
}