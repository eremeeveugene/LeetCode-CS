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

/// <inheritdoc />
public sealed class DesignTaskManagerDictionaryWithPriorityQueue : IDesignTaskManager
{
    private readonly PriorityQueue<TaskIdPriority, TaskIdPriority> _taskIdPriorityQueue = new();
    private readonly Dictionary<int, UserIdPriority> _taskIdToUserIdPriorityDictionary = [];

    /// <summary>
    ///     Initializes a new instance of the <see cref="DesignTaskManagerDictionaryWithPriorityQueue" /> class.
    /// </summary>
    /// <param name="tasks">The initial tasks, where each task is [userId, taskId, priority].</param>
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public DesignTaskManagerDictionaryWithPriorityQueue(IList<IList<int>> tasks)
    {
        var n = tasks.Count;

        for (var i = 0; i < n; i++)
        {
            var userId = tasks[i][0];
            var taskId = tasks[i][1];
            var priority = tasks[i][2];

            _taskIdToUserIdPriorityDictionary.Add(taskId, new UserIdPriority(userId, priority));

            var taskIdPriority = new TaskIdPriority(taskId, priority);

            _taskIdPriorityQueue.Enqueue(taskIdPriority, taskIdPriority);
        }
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Add(int userId, int taskId, int priority)
    {
        _taskIdToUserIdPriorityDictionary[taskId] = new UserIdPriority(userId, priority);

        var taskIdPriority = new TaskIdPriority(taskId, priority);

        _taskIdPriorityQueue.Enqueue(taskIdPriority, taskIdPriority);
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Edit(int taskId, int newPriority)
    {
        var userIdPriority = _taskIdToUserIdPriorityDictionary[taskId];
        var editedUserIdPriority = userIdPriority with { Priority = newPriority };

        _taskIdToUserIdPriorityDictionary[taskId] = editedUserIdPriority;

        var taskIdPriority = new TaskIdPriority(taskId, newPriority);

        _taskIdPriorityQueue.Enqueue(taskIdPriority, taskIdPriority);
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Rmv(int taskId)
    {
        _taskIdToUserIdPriorityDictionary.Remove(taskId);
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int ExecTop()
    {
        while (_taskIdPriorityQueue.Count > 0)
        {
            var taskIdPriority = _taskIdPriorityQueue.Dequeue();

            if (!_taskIdToUserIdPriorityDictionary.TryGetValue(taskIdPriority.TaskId, out var userIdPriority) ||
                userIdPriority.Priority != taskIdPriority.Priority)
            {
                continue;
            }

            Rmv(taskIdPriority.TaskId);

            return userIdPriority.UserId;
        }

        return -1;
    }

    private readonly record struct UserIdPriority(int UserId, int Priority);

    private readonly struct TaskIdPriority : IComparable<TaskIdPriority>
    {
        public int TaskId { get; }

        public int Priority { get; }

        public TaskIdPriority(int taskId, int priority)
        {
            TaskId = taskId;
            Priority = priority;
        }

        public int CompareTo(TaskIdPriority taskPriority)
        {
            var priorityCompare = CompareToPriority(taskPriority.Priority);

            if (priorityCompare == 0)
            {
                return CompareToTaskId(taskPriority.TaskId);
            }

            return priorityCompare;
        }

        private int CompareToPriority(int priority)
        {
            return priority.CompareTo(Priority);
        }

        private int CompareToTaskId(int taskId)
        {
            return taskId.CompareTo(TaskId);
        }
    }
}