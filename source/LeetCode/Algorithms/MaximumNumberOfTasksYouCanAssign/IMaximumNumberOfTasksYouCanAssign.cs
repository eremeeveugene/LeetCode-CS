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

namespace LeetCode.Algorithms.MaximumNumberOfTasksYouCanAssign;

/// <summary>
///     https://leetcode.com/problems/maximum-number-of-tasks-you-can-assign/description/
/// </summary>
public interface IMaximumNumberOfTasksYouCanAssign
{
    int MaxTaskAssign(int[] tasks, int[] workers, int pills, int strength);
}