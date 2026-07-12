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

namespace LeetCode.Algorithms.AddTwoNumbers2;

/// <summary>
///     https://leetcode.com/problems/add-two-numbers-ii/description/
/// </summary>
public interface IAddTwoNumbers2
{
    /// <summary>
    ///     Adds the two numbers represented by the linked lists <paramref name="l1" /> and <paramref name="l2" />, whose
    ///     most significant digits come first, and returns the sum as a linked list.
    /// </summary>
    /// <param name="l1">The first linked list of digits with the most significant digit first.</param>
    /// <param name="l2">The second linked list of digits with the most significant digit first.</param>
    /// <returns>The head of a linked list representing the sum with the most significant digit first.</returns>
    ListNode AddTwoNumbers(ListNode l1, ListNode l2);
}