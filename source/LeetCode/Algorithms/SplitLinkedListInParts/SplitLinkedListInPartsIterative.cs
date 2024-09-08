﻿using LeetCode.Core.Models;

namespace LeetCode.Algorithms.SplitLinkedListInParts;

/// <inheritdoc />
public class SplitLinkedListInPartsIterative : ISplitLinkedListInParts
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="head"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public ListNode?[] SplitListToParts(ListNode? head, int k)
    {
        if (head == null)
        {
            return new ListNode[k];
        }

        var length = 0;
        var currentNode = head;

        while (currentNode != null)
        {
            length++;

            currentNode = currentNode.next;
        }

        var partSize = length / k;
        var extraNodesCount = length % k;

        var result = new ListNode?[k];

        currentNode = head;

        for (var i = 0; i < k && currentNode != null; i++)
        {
            result[i] = currentNode;

            var currentPartSize = partSize;

            if (extraNodesCount > 0)
            {
                currentPartSize++;

                extraNodesCount--;
            }

            for (var j = 0; j < currentPartSize - 1; j++)
            {
                currentNode = currentNode?.next;
            }

            var nextPart = currentNode?.next;

            if (currentNode != null)
            {
                currentNode.next = null;
            }

            currentNode = nextPart;
        }

        return result;
    }
}