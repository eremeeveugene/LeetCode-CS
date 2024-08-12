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

namespace LeetCode.Algorithms.KthLargestElementInStream;

/// <inheritdoc />
public class KthLargestElementInStreamPriorityQueue : IKthLargestElementInStream
{
    private readonly int _k;
    private readonly PriorityQueue<int, int> _priorityQueue = new();

    public KthLargestElementInStreamPriorityQueue(int k, IEnumerable<int> nums)
    {
        _k = k;

        foreach (var num in nums)
        {
            Add(num);
        }
    }

    /// <summary>
    ///     Time complexity - O(log k)
    ///     Space complexity - O(k)
    /// </summary>
    /// <param name="val"></param>
    /// <returns></returns>
    public int Add(int val)
    {
        if (_priorityQueue.Count < _k)
        {
            _priorityQueue.Enqueue(val, val);
        }
        else if (val > _priorityQueue.Peek())
        {
            _priorityQueue.Dequeue();
            _priorityQueue.Enqueue(val, val);
        }

        return _priorityQueue.Peek();
    }
}