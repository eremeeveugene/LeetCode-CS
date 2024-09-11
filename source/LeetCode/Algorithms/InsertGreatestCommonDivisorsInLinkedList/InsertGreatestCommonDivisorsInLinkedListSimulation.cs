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

namespace LeetCode.Algorithms.InsertGreatestCommonDivisorsInLinkedList;

/// <inheritdoc />
public class InsertGreatestCommonDivisorsInLinkedListSimulation : IInsertGreatestCommonDivisorsInLinkedList
{
    /// <summary>
    ///     Time complexity - O(n * log min(a,b))
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public ListNode? InsertGreatestCommonDivisors(ListNode head)
    {
        var dummyHead = new ListNode(0, head);

        var previousNode = head;
        var currentNode = head.next;

        while (currentNode != null)
        {
            var greatestCommonDivisor = GetGreatestCommonDivisor(previousNode.val, currentNode.val);

            previousNode.next = new ListNode(greatestCommonDivisor, currentNode);

            previousNode = currentNode;
            currentNode = currentNode.next;
        }

        return dummyHead.next;
    }

    private static int GetGreatestCommonDivisor(int a, int b)
    {
        while (b != 0)
        {
            var temp = a % b;
            a = b;
            b = temp;
        }

        return a;
    }
}