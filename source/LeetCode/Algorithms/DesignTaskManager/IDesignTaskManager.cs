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

namespace LeetCode.Algorithms.DesignTaskManager;

/// <summary>
///     https://leetcode.com/problems/design-task-manager/description/
/// </summary>
public interface IDesignTaskManager
{
    /// <summary>
    ///     Adds a task with the given priority for the specified user to the task manager.
    /// </summary>
    /// <param name="userId">The identifier of the user who owns the task.</param>
    /// <param name="taskId">The unique identifier of the task.</param>
    /// <param name="priority">The priority of the task.</param>
    void Add(int userId, int taskId, int priority);

    /// <summary>
    ///     Updates the priority of the existing task with the given identifier.
    /// </summary>
    /// <param name="taskId">The unique identifier of the task to update.</param>
    /// <param name="newPriority">The new priority of the task.</param>
    void Edit(int taskId, int newPriority);

    /// <summary>
    ///     Removes the task with the given identifier from the task manager.
    /// </summary>
    /// <param name="taskId">The unique identifier of the task to remove.</param>
    void Rmv(int taskId);

    /// <summary>
    ///     Executes the task with the highest priority (breaking ties by the highest task identifier) and removes it from
    ///     the task manager.
    /// </summary>
    /// <returns>The identifier of the user associated with the executed task, or -1 if there are no tasks.</returns>
    int ExecTop();
}