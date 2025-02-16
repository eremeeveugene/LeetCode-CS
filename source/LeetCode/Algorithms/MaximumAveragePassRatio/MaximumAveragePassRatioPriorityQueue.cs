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

namespace LeetCode.Algorithms.MaximumAveragePassRatio;

/// <inheritdoc />
public class MaximumAveragePassRatioPriorityQueue : IMaximumAveragePassRatio
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="classes"></param>
    /// <param name="extraStudents"></param>
    /// <returns></returns>
    public double MaxAverageRatio(int[][] classes, int extraStudents)
    {
        var ratiosPriorityQueue = new PriorityQueue<(int Pass, int Total), double>();

        foreach (var @class in classes)
        {
            var pass = @class[0];
            var total = @class[1];

            var delta = GetDelta(pass, total);

            ratiosPriorityQueue.Enqueue((pass, total), -delta);
        }

        for (var i = 0; i < extraStudents; i++)
        {
            var ratio = ratiosPriorityQueue.Dequeue();

            ratio.Pass++;
            ratio.Total++;

            var delta = GetDelta(ratio.Pass, ratio.Total);

            ratiosPriorityQueue.Enqueue((ratio.Pass, ratio.Total), -delta);
        }

        double average = 0;

        while (ratiosPriorityQueue.Count > 0)
        {
            var ratio = ratiosPriorityQueue.Dequeue();

            average += (double)ratio.Pass / ratio.Total / classes.Length;
        }

        return average;
    }

    private static double GetDelta(int pass, int total)
    {
        var currentRatio = (double)pass / total;
        var newRatio = (double)(pass + 1) / (total + 1);

        return newRatio - currentRatio;
    }
}