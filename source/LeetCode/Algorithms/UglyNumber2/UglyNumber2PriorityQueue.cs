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

namespace LeetCode.Algorithms.UglyNumber2;

/// <inheritdoc />
public class UglyNumber2PriorityQueue : IUglyNumber2
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int NthUglyNumber(int n)
    {
        var hashSet = new HashSet<long>();
        var priorityQueue = new PriorityQueue<long, long>();
        priorityQueue.Enqueue(1, 1);

        long current = 1;

        while (hashSet.Count < n)
        {
            current = priorityQueue.Dequeue();

            if (!hashSet.Add(current))
            {
                continue;
            }

            priorityQueue.Enqueue(current * 2, current * 2);
            priorityQueue.Enqueue(current * 3, current * 3);
            priorityQueue.Enqueue(current * 5, current * 5);
        }

        return (int)current;
    }
}