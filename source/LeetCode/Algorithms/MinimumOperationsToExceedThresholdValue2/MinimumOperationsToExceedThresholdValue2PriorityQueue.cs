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

namespace LeetCode.Algorithms.MinimumOperationsToExceedThresholdValue2;

/// <inheritdoc />
public sealed class MinimumOperationsToExceedThresholdValue2PriorityQueue : IMinimumOperationsToExceedThresholdValue2
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int MinOperations(int[] nums, int k)
    {
        var minOperations = 0;

        var priorityQueue = new PriorityQueue<long, long>();

        foreach (var num in nums)
        {
            priorityQueue.Enqueue(num, num);
        }

        while (priorityQueue.Count > 1 && priorityQueue.Peek() < k)
        {
            var first = priorityQueue.Dequeue();
            var second = priorityQueue.Dequeue();

            var num = (first * 2) + second;

            priorityQueue.Enqueue(num, num);

            minOperations++;
        }

        return minOperations;
    }
}