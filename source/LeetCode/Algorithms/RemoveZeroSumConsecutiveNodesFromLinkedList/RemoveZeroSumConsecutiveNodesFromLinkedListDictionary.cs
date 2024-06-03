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

namespace LeetCode.Algorithms.RemoveZeroSumConsecutiveNodesFromLinkedList;

/// <inheritdoc />
public class RemoveZeroSumConsecutiveNodesFromLinkedListDictionary : IRemoveZeroSumConsecutiveNodesFromLinkedList
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public ListNode? RemoveZeroSumSublists(ListNode? head)
    {
        var dummyHead = new ListNode(0, head);

        var prefixSumDictionary = new Dictionary<int, ListNode>();

        var prefixSum = 0;

        for (var current = dummyHead; current != null; current = current.next)
        {
            prefixSum += current.val;
            prefixSumDictionary[prefixSum] = current;
        }

        prefixSum = 0;

        for (var current = dummyHead; current != null; current = current.next)
        {
            prefixSum += current.val;

            if (prefixSumDictionary.TryGetValue(prefixSum, out var value))
            {
                current.next = value.next;
            }
        }

        return dummyHead.next;
    }
}