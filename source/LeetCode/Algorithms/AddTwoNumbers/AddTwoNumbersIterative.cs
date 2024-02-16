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

namespace LeetCode.Algorithms.AddTwoNumbers;

/// <inheritdoc />
public class AddTwoNumbersIterative : IAddTwoNumbers
{
    /// <summary>
    ///     Time complexity - O(max(n, m))
    ///     Space complexity - O(max(n, m))
    /// </summary>
    /// <param name="l1"></param>
    /// <param name="l2"></param>
    /// <returns></returns>
    public ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        var dummyHead = new ListNode();
        var current = dummyHead;
        var carry = 0;

        while (l1 != null || l2 != null || carry != 0)
        {
            var sum = carry;

            if (l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;
            }

            if (l2 != null)
            {
                sum += l2.val;
                l2 = l2.next;
            }

            carry = sum / 10;
            current.next = new ListNode(sum % 10);
            current = current.next;
        }

        return dummyHead.next;
    }
}