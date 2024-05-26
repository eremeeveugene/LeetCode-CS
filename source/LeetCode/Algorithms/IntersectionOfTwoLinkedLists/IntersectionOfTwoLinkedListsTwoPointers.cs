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

/// <inheritdoc />
public class IntersectionOfTwoLinkedListsTwoPointers : IIntersectionOfTwoLinkedLists
{
    /// <summary>
    ///     Time complexity - O(m + n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="headA"></param>
    /// <param name="headB"></param>
    /// <returns></returns>
    public ListNode? GetIntersectionNode(ListNode? headA, ListNode? headB)
    {
        var headAPointer = headA;
        var headBPointer = headB;

        while (headAPointer != headBPointer)
        {
            headAPointer = headAPointer == null ? headB : headAPointer.next;

            headBPointer = headBPointer == null ? headA : headBPointer.next;
        }

        return headAPointer;
    }
}