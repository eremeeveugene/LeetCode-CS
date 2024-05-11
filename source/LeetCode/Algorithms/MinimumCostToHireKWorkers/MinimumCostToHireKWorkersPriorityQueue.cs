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

namespace LeetCode.Algorithms.MinimumCostToHireKWorkers;

/// <summary>
///     https://leetcode.com/problems/minimum-cost-to-hire-k-workers/
/// </summary>
public class MinimumCostToHireKWorkersPriorityQueue : IMinimumCostToHireKWorkers
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="quality"></param>
    /// <param name="wage"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public double MincostToHireWorkers(int[] quality, int[] wage, int k)
    {
        var workers = new (double ratio, int quality)[quality.Length];

        for (var i = 0; i < quality.Length; ++i)
        {
            workers[i] = ((double)wage[i] / quality[i], quality[i]);
        }

        Array.Sort(workers, (a, b) => a.ratio.CompareTo(b.ratio));

        var result = double.MaxValue;

        var priorityQueue = new PriorityQueue<double, double>();

        double sum = 0;

        foreach (var worker in workers)
        {
            sum += worker.quality;

            priorityQueue.Enqueue(-worker.quality, -worker.quality);

            if (priorityQueue.Count > k)
            {
                sum += priorityQueue.Dequeue();
            }

            if (priorityQueue.Count == k)
            {
                result = Math.Min(result, sum * worker.ratio);
            }
        }

        return result;
    }
}