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

namespace LeetCode.Algorithms.ProcessTasksUsingServers;

/// <inheritdoc />
public sealed class ProcessTasksUsingServersPriorityQueue : IProcessTasksUsingServers
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O((n + m) log n), where m is the length of tasks
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] AssignTasks(int[] servers, int[] tasks)
    {
        var freeServersPriorityQueue = new PriorityQueue<(int Index, int Weight), (int Weight, int Index)>();

        var n = servers.Length;

        for (var index = 0; index < n; index++)
        {
            var weight = servers[index];

            freeServersPriorityQueue.Enqueue((index, weight), (weight, index));
        }

        var currentTime = 0;

        var busyServersPriorityQueue = new PriorityQueue<(int Index, int Weight), int>();

        var m = tasks.Length;

        for (var time = 0; time < m; time++)
        {
            var task = tasks[time];

            currentTime = Math.Max(currentTime, time);

            if (freeServersPriorityQueue.Count == 0)
            {
                busyServersPriorityQueue.TryPeek(out _, out var earliestFreeTime);

                currentTime = earliestFreeTime;
            }

            while (busyServersPriorityQueue.TryPeek(out var releasedServer, out var freeTime) && freeTime <= currentTime)
            {
                busyServersPriorityQueue.Dequeue();

                freeServersPriorityQueue.Enqueue(releasedServer, (releasedServer.Weight, releasedServer.Index));
            }

            var assignedServer = freeServersPriorityQueue.Dequeue();

            busyServersPriorityQueue.Enqueue(assignedServer, currentTime + task);

            tasks[time] = assignedServer.Index;
        }

        return tasks;
    }
}