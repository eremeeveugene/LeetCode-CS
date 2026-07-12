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

namespace LeetCode.Algorithms.TaskScheduler;

/// <summary>
///     https://leetcode.com/problems/task-scheduler/description/
/// </summary>
public interface ITaskScheduler
{
    /// <summary>
    ///     Computes the least number of CPU intervals required to complete all the given <paramref name="tasks" />,
    ///     where identical tasks must be separated by at least <paramref name="n" /> intervals.
    /// </summary>
    /// <param name="tasks">The array of characters representing the tasks to be executed.</param>
    /// <param name="n">The minimum cooldown interval count required between two identical tasks.</param>
    /// <returns>The minimum number of intervals needed to finish all tasks.</returns>
    int LeastInterval(char[] tasks, int n);
}