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

namespace LeetCode.Algorithms.RemoveLinkedListElements;

/// <inheritdoc />
public class RemoveLinkedListElementsRecursive : IRemoveLinkedListElements
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="head"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public ListNode? RemoveElements(ListNode? head, int val)
    {
        if (head == null)
        {
            return null;
        }

        head.next = RemoveElements(head.next, val);

        return head.val == val ? head.next : head;
    }
}