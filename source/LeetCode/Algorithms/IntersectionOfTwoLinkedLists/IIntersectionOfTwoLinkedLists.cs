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

namespace LeetCode.Algorithms.IntersectionOfTwoLinkedLists;

/// <summary>
///     https://leetcode.com/problems/intersection-of-two-linked-lists/
/// </summary>
public interface IIntersectionOfTwoLinkedLists
{
    ListNode? GetIntersectionNode(ListNode? headA, ListNode? headB);
}