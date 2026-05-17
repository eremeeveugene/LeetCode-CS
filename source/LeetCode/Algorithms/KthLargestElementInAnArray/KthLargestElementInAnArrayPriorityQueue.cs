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

namespace LeetCode.Algorithms.KthLargestElementInAnArray;

/// <inheritdoc />
public sealed class KthLargestElementInAnArrayPriorityQueue : IKthLargestElementInAnArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log k)
    ///     Space complexity - O(k)
    /// </remarks>
    public int FindKthLargest(int[] nums, int k)
    {
        var n = nums.Length;

        var priorityQueue = new PriorityQueue<int, int>(k);

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            if (priorityQueue.Count < k)
            {
                priorityQueue.Enqueue(num, num);
            }
            else if (num > priorityQueue.Peek())
            {
                priorityQueue.DequeueEnqueue(num, num);
            }
        }

        return priorityQueue.Peek();
    }
}