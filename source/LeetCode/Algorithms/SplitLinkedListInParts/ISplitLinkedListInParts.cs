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

namespace LeetCode.Algorithms.SplitLinkedListInParts;

/// <summary>
///     https://leetcode.com/problems/split-linked-list-in-parts/
/// </summary>
public interface ISplitLinkedListInParts
{
    /// <summary>
    ///     Splits the linked list starting at <paramref name="head" /> into <paramref name="k" /> consecutive
    ///     parts of as equal size as possible, with earlier parts being at least as large as later parts.
    /// </summary>
    /// <param name="head">The head of the linked list to split.</param>
    /// <param name="k">The number of parts to split the list into.</param>
    /// <returns>An array of <paramref name="k" /> linked list heads representing the split parts.</returns>
    ListNode?[] SplitListToParts(ListNode? head, int k);
}