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

/// <summary>
///     https://leetcode.com/problems/maximum-number-of-tasks-you-can-assign/description/
/// </summary>
public interface IMaximumNumberOfTasksYouCanAssign
{
    /// <summary>
    ///     Assigns workers from <paramref name="workers" /> to tasks from <paramref name="tasks" />, optionally boosting
    ///     up to <paramref name="pills" /> workers' strength by <paramref name="strength" />, to maximize the number of
    ///     completed tasks (a worker can complete a task only if their strength is at least the task's requirement).
    /// </summary>
    /// <param name="tasks">The array of strength requirements for each task.</param>
    /// <param name="workers">The array of strength values for each worker.</param>
    /// <param name="pills">The number of magic pills available, each boosting one worker's strength.</param>
    /// <param name="strength">The amount of strength gained by a worker who takes a pill.</param>
    /// <returns>The maximum number of tasks that can be completed.</returns>
    int MaxTaskAssign(int[] tasks, int[] workers, int pills, int strength);
}