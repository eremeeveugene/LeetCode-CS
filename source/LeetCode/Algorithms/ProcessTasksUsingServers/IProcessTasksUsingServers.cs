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

/// <summary>
///     https://leetcode.com/problems/process-tasks-using-servers/description/
/// </summary>
public interface IProcessTasksUsingServers
{
    /// <summary>
    ///     Assigns each task, in order of arrival, to the free server with the smallest weight, breaking ties by the
    ///     smallest index, waiting for a server to become free when none is available.
    /// </summary>
    /// <param name="servers">The weights of the servers.</param>
    /// <param name="tasks">The processing times of the tasks, where the jth task arrives at second j.</param>
    /// <returns>The index of the server each task is assigned to, in the order of <paramref name="tasks" />.</returns>
    int[] AssignTasks(int[] servers, int[] tasks);
}