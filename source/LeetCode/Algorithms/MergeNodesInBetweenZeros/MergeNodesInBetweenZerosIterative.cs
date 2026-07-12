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

/// <inheritdoc />
public sealed class MergeNodesInBetweenZerosIterative : IMergeNodesInBetweenZeros
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public ListNode? MergeNodes(ListNode? head)
    {
        if (head == null)
        {
            return null;
        }

        var listNode = head;

        while (listNode != null)
        {
            if (listNode.val == 0)
            {
                var sum = 0;

                var zeroNode = listNode.next;

                while (zeroNode != null && zeroNode.val != 0)
                {
                    sum += zeroNode.val;

                    zeroNode = zeroNode.next;
                }

                listNode.val = sum;
                listNode.next = zeroNode is null or { val: 0, next: null } ? null : zeroNode;
            }

            listNode = listNode.next;
        }

        return head;
    }
}