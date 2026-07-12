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

namespace LeetCode.Algorithms.LinkedListCycle;

/// <summary>
///     https://leetcode.com/problems/linked-list-cycle/description/
/// </summary>
public interface ILinkedListCycle
{
    /// <summary>
    ///     Determines whether the linked list starting at <paramref name="head" /> contains a cycle.
    /// </summary>
    /// <param name="head">The head node of the linked list to examine.</param>
    /// <returns><see langword="true" /> if the linked list contains a cycle; otherwise, <see langword="false" />.</returns>
    bool HasCycle(ListNode? head);
}