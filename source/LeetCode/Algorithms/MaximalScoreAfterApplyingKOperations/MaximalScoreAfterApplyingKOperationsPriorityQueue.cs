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

namespace LeetCode.Algorithms.MaximalScoreAfterApplyingKOperations;

/// <inheritdoc />
public class MaximalScoreAfterApplyingKOperationsPriorityQueue : IMaximalScoreAfterApplyingKOperations
{
    /// <summary>
    ///     Time complexity - O(k log n + n log n), where n is the number of elements in the queue and k is the number of new
    ///     elements
    ///     Space complexity - O(n + k), where n is the number of elements in the queue and k is the number of new elements
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public long MaxKelements(int[] nums, int k)
    {
        var priorityQueue = new PriorityQueue<int, int>();

        foreach (var num in nums)
        {
            priorityQueue.Enqueue(num, -num);
        }

        long result = 0;

        for (var i = 0; i < k; i++)
        {
            var maxElement = priorityQueue.Dequeue();

            result += maxElement;

            var newElement = (int)Math.Ceiling(maxElement / 3.0);

            priorityQueue.Enqueue(newElement, -newElement);
        }

        return result;
    }
}