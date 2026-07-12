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

namespace LeetCode.Algorithms.IntersectionOfTwoLinkedLists;

/// <inheritdoc />
public sealed class IntersectionOfTwoLinkedListsBruteForce : IIntersectionOfTwoLinkedLists
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </remarks>
    public ListNode? GetIntersectionNode(ListNode? headA, ListNode? headB)
    {
        var headAPointer = headA;

        while (headAPointer != null)
        {
            var headBPointer = headB;

            while (headBPointer != null)
            {
                if (headAPointer == headBPointer)
                {
                    return headAPointer;
                }

                headBPointer = headBPointer.next;
            }

            headAPointer = headAPointer.next;
        }

        return null;
    }
}