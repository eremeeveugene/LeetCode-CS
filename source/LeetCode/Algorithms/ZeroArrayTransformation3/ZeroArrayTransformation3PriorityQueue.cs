// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.ZeroArrayTransformation3;

/// <inheritdoc />
public class ZeroArrayTransformation3PriorityQueue : IZeroArrayTransformation3
{
    /// <summary>
    ///     Time complexity - O((n + q) log q)
    ///     sPACE complexity - O(n + q)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="queries"></param>
    /// <returns></returns>
    public int MaxRemoval(int[] nums, int[][] queries)
    {
        Array.Sort(queries, (a, b) => a[0] - b[0]);

        var prefixSum = new int[nums.Length + 1];

        var priorityQueue = new PriorityQueue<int, int>();

        var count = 0;

        for (int i = 0, j = 0; i < nums.Length; i++)
        {
            count += prefixSum[i];

            while (j < queries.Length && queries[j][0] == i)
            {
                priorityQueue.Enqueue(queries[j][1], -queries[j][1]);

                j++;
            }

            while (count < nums[i] && priorityQueue.Count > 0 && priorityQueue.Peek() >= i)
            {
                count += 1;

                prefixSum[priorityQueue.Dequeue() + 1]--;
            }

            if (count < nums[i])
            {
                return -1;
            }
        }

        return priorityQueue.Count;
    }
}