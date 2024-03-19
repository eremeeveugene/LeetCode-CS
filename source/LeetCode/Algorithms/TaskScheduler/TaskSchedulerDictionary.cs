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

namespace LeetCode.Algorithms.TaskScheduler;

/// <inheritdoc />
public class TaskSchedulerDictionary : ITaskScheduler
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="tasks"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int LeastInterval(char[] tasks, int n)
    {
        var taskCounts = new Dictionary<char, int>();

        foreach (var task in tasks)
        {
            if (!taskCounts.TryAdd(task, 1))
            {
                taskCounts[task]++;
            }
        }

        var maxFrequency = 0;
        var tasksWithMaxFrequency = 0;

        foreach (var count in taskCounts.Values)
        {
            if (count > maxFrequency)
            {
                maxFrequency = count;
                tasksWithMaxFrequency = 1;
            }
            else if (count == maxFrequency)
            {
                tasksWithMaxFrequency++;
            }
        }

        var partCount = maxFrequency - 1;
        var partLength = n - (tasksWithMaxFrequency - 1);
        var emptySlots = partCount * partLength;
        var availableTasks = tasks.Length - (maxFrequency * tasksWithMaxFrequency);
        var idles = Math.Max(0, emptySlots - availableTasks);

        return tasks.Length + idles;
    }
}