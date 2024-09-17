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

using LeetCode.Algorithms.TaskScheduler;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.TaskScheduler;

public abstract class TaskSchedulerTestsBase<T> where T : ITaskScheduler, new()
{
    [TestMethod]
    [DataRow("['A','A','A','B','B','B']", 2, 8)]
    [DataRow("['A','C','A','B','D','B']", 1, 6)]
    [DataRow("['A','A','A','B','B','B']", 3, 10)]
    public void LeastInterval_GivenTasksAndCooldownPeriod_ReturnsMinimumIntervalsNeeded(string tasksJsonArray, int n,
        int expectedResult)
    {
        // Arrange
        var tasks = JsonHelper<char>.DeserializeToArray(tasksJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.LeastInterval(tasks, n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}