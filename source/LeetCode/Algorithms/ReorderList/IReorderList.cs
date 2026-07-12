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

namespace LeetCode.Algorithms.ReorderList;

/// <summary>
///     https://leetcode.com/problems/reorder-list/description/
/// </summary>
public interface IReorderList
{
    /// <summary>
    ///     Reorders the linked list starting at <paramref name="head" /> in place into the pattern
    ///     first-node, last-node, second-node, second-to-last-node, and so on.
    /// </summary>
    /// <param name="head">The head of the linked list to reorder in place.</param>
    void ReorderList(ListNode? head);
}