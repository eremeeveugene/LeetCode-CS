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

/// <inheritdoc />
public sealed class MaximumTwinSumOfALinkedListReverse : IMaximumTwinSumOfALinkedList
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int PairSum(ListNode head)
    {
        var slow = head;
        var fast = head;

        while (fast != null)
        {
            slow = slow!.next;
            fast = fast.next?.next;
        }

        var previous = default(ListNode);
        var current = slow;

        while (current != null)
        {
            var next = current.next;

            current.next = previous;
            previous = current;
            current = next;
        }

        var firstHalf = head;
        var secondHalf = previous;
        var maxSum = 0;

        while (secondHalf != null)
        {
            var sum = firstHalf!.val + secondHalf.val;

            maxSum = Math.Max(maxSum, sum);

            firstHalf = firstHalf.next;
            secondHalf = secondHalf.next;
        }

        return maxSum;
    }
}