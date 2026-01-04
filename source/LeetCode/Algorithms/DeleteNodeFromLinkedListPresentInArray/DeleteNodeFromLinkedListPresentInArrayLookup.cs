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

namespace LeetCode.Algorithms.DeleteNodeFromLinkedListPresentInArray;

/// <inheritdoc />
public class DeleteNodeFromLinkedListPresentInArrayLookup : IDeleteNodeFromLinkedListPresentInArray
{
    /// <summary>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="head"></param>
    /// <returns></returns>
    public ListNode? ModifiedList(int[] nums, ListNode? head)
    {
        Span<bool> numsLookup = stackalloc bool[100001];

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            numsLookup[num] = true;
        }

        var dummyHead = new ListNode(0, head);

        var current = dummyHead;

        while (current.next != null)
        {
            if (numsLookup[current.next.val])
            {
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }

        return dummyHead.next;
    }
}