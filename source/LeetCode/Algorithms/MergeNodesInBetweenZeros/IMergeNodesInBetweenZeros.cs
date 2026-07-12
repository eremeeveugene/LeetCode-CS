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

namespace LeetCode.Algorithms.MergeNodesInBetweenZeros;

/// <summary>
///     https://leetcode.com/problems/merge-nodes-in-between-zeros/description/
/// </summary>
public interface IMergeNodesInBetweenZeros
{
    /// <summary>
    ///     Merges every group of nodes lying between two consecutive zero nodes of <paramref name="head" /> into a
    ///     single node whose value is the sum of the group.
    /// </summary>
    /// <param name="head">The head of the linked list, which starts and ends with a node of value 0.</param>
    /// <returns>The head of the modified linked list containing the merged sums.</returns>
    ListNode? MergeNodes(ListNode? head);
}