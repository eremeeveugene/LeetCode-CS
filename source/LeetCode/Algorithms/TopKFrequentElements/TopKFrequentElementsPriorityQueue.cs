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

using System.Runtime.InteropServices;

namespace LeetCode.Algorithms.TopKFrequentElements;

/// <inheritdoc />
public sealed class TopKFrequentElementsPriorityQueue : ITopKFrequentElements
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log k)
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] TopKFrequent(int[] nums, int k)
    {
        var numToFrequencyDictionary = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            ref var count = ref CollectionsMarshal.GetValueRefOrAddDefault(numToFrequencyDictionary, num, out _);

            count++;
        }

        var result = new int[k];

        var uniqueNums = new int[numToFrequencyDictionary.Count];

        numToFrequencyDictionary.Keys.CopyTo(uniqueNums, 0);

        if (uniqueNums.Length == k)
        {
            for (var i = 0; i < uniqueNums.Length; i++)
            {
                result[i] = uniqueNums[i];
            }

            return result;
        }

        var numsPriorityQueue = new PriorityQueue<int, int>();

        for (var i = 0; i < uniqueNums.Length; i++)
        {
            var num = uniqueNums[i];
            var frequency = numToFrequencyDictionary[num];

            if (numsPriorityQueue.Count < k)
            {
                numsPriorityQueue.Enqueue(num, frequency);
            }
            else
            {
                numsPriorityQueue.EnqueueDequeue(num, frequency);
            }
        }

        for (var i = 0; i < k; i++)
        {
            result[i] = numsPriorityQueue.Dequeue();
        }

        return result;
    }
}