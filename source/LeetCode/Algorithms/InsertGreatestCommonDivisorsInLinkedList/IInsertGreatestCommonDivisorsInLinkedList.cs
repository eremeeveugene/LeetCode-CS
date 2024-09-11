// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Core.Models;

namespace LeetCode.Algorithms.InsertGreatestCommonDivisorsInLinkedList;

/// <summary>
///     https://leetcode.com/problems/insert-greatest-common-divisors-in-linked-list/
/// </summary>
public interface IInsertGreatestCommonDivisorsInLinkedList
{
    ListNode? InsertGreatestCommonDivisors(ListNode head);
}