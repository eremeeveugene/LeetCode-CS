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

namespace LeetCode.Algorithms.DeleteNodeInLinkedList;

/// <inheritdoc />
public class DeleteNodeInLinkedListIterative : IDeleteNodeInLinkedList
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="node"></param>
    public void DeleteNode(ListNode? node)
    {
        while (node is { next: not null })
        {
            node.val = node.next.val;

            if (node.next.next == null)
            {
                node.next = null;
            }

            node = node.next;
        }
    }
}