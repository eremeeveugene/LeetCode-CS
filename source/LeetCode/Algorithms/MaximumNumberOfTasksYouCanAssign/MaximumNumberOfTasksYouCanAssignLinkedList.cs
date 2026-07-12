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

namespace LeetCode.Algorithms.MaximumNumberOfTasksYouCanAssign;

/// <inheritdoc />
public sealed class MaximumNumberOfTasksYouCanAssignLinkedList : IMaximumNumberOfTasksYouCanAssign
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n + m log m + min(n, m) × log(min(n, m)))
    ///     Space complexity - O(min(n, m))
    /// </remarks>
    public int MaxTaskAssign(int[] tasks, int[] workers, int pills, int strength)
    {
        Array.Sort(tasks);
        Array.Sort(workers);

        var left = 0;
        var right = Math.Min(tasks.Length, workers.Length);
        var result = 0;

        while (left <= right)
        {
            var mid = left + ((right - left) / 2);

            if (CanComplete(tasks, workers, pills, strength, mid))
            {
                result = mid;

                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return result;
    }

    private static bool CanComplete(int[] tasks, int[] workers, int pills, int strength, int k)
    {
        if (k == 0)
        {
            return true;
        }

        if (k > workers.Length)
        {
            return false;
        }

        var linkedList = new LinkedList<int>();
        var workerIndex = workers.Length - 1;
        var usedPills = 0;

        for (var i = k - 1; i >= 0; i--)
        {
            while (workerIndex >= workers.Length - k && workers[workerIndex] + strength >= tasks[i])
            {
                linkedList.AddLast(workers[workerIndex]);

                workerIndex--;
            }

            if (linkedList.Count == 0)
            {
                return false;
            }

            if (linkedList.First != null && linkedList.First.Value >= tasks[i])
            {
                linkedList.RemoveFirst();
            }
            else
            {
                if (usedPills >= pills)
                {
                    return false;
                }

                usedPills++;

                linkedList.RemoveLast();
            }
        }

        return true;
    }
}