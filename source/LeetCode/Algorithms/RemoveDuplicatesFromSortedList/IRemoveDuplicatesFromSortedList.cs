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

namespace LeetCode.Algorithms.RemoveDuplicatesFromSortedList;

/// <summary>
///     https://leetcode.com/problems/remove-duplicates-from-sorted-list/description/
/// </summary>
public interface IRemoveDuplicatesFromSortedList
{
    /// <summary>
    ///     Removes duplicate values from the sorted linked list starting at <paramref name="head" /> so that each value
    ///     appears only once.
    /// </summary>
    /// <param name="head">The head of the sorted linked list.</param>
    /// <returns>The head of the linked list after duplicate values have been removed.</returns>
    ListNode? DeleteDuplicates(ListNode? head);
}