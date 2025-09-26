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

namespace LeetCode.Algorithms.DesignTaskManager;

/// <summary>
///     https://leetcode.com/problems/design-task-manager/description/
/// </summary>
public interface IDesignTaskManager
{
    void Add(int userId, int taskId, int priority);

    void Edit(int taskId, int newPriority);

    void Rmv(int taskId);

    int ExecTop();
}