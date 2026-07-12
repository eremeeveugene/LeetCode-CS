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

namespace LeetCode.Algorithms.PalindromeLinkedList;

/// <summary>
///     https://leetcode.com/problems/palindrome-linked-list/
/// </summary>
public interface IPalindromeLinkedList
{
    /// <summary>
    ///     Determines whether the singly linked list starting at <paramref name="head" /> reads the same forwards
    ///     and backwards.
    /// </summary>
    /// <param name="head">The head node of the singly linked list to check, or <see langword="null" /> for an empty list.</param>
    /// <returns><see langword="true" /> if the linked list is a palindrome; otherwise, <see langword="false" />.</returns>
    bool IsPalindrome(ListNode? head);
}