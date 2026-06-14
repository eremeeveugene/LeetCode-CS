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

namespace LeetCode.Algorithms.MaximumTwinSumOfALinkedList;

/// <summary>
///     https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list/description/
/// </summary>
public interface IMaximumTwinSumOfALinkedList
{
    /// <summary>
    ///     In a linked list of even size <c>n</c>, the <c>i</c>th node (0-indexed) is the twin of the <c>(n - 1 - i)</c>th
    ///     node for <c>0 &lt;= i &lt;= (n / 2) - 1</c>, and the twin sum is the sum of a node and its twin.
    /// </summary>
    /// <param name="head">The head of a linked list with an even number of nodes.</param>
    /// <returns>The maximum twin sum of the linked list.</returns>
    int PairSum(ListNode head);
}