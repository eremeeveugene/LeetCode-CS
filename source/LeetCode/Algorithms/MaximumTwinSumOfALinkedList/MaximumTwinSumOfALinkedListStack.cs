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
public sealed class MaximumTwinSumOfALinkedListStack : IMaximumTwinSumOfALinkedList
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int PairSum(ListNode head)
    {
        var slow = head;
        var fast = head;

        var firstHalfValues = new Stack<int>();

        while (fast is { next: not null })
        {
            firstHalfValues.Push(slow!.val);

            slow = slow.next;

            fast = fast.next.next;
        }

        var maxSum = 0;

        while (slow != null && firstHalfValues.Count > 0)
        {
            var sum = firstHalfValues.Pop() + slow.val;

            maxSum = Math.Max(maxSum, sum);

            slow = slow.next;
        }

        return maxSum;
    }
}