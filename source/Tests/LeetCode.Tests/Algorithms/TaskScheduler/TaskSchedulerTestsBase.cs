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

using LeetCode.Algorithms.TaskScheduler;

namespace LeetCode.Tests.Algorithms.TaskScheduler;

public abstract class TaskSchedulerTestsBase<T> where T : ITaskScheduler, new()
{
    [TestMethod]
    [DataRow(new[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 2, 8)]
    [DataRow(new[] { 'A', 'C', 'A', 'B', 'D', 'B' }, 1, 6)]
    [DataRow(new[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 3, 10)]
    [DataRow(new[] { 'A' }, 0, 1)]
    [DataRow(new[] { 'A' }, 5, 1)]
    [DataRow(new[] { 'A', 'A' }, 0, 2)]
    [DataRow(new[] { 'A', 'A' }, 2, 4)]
    [DataRow(new[] { 'A', 'A', 'B' }, 2, 4)]
    [DataRow(new[] { 'A', 'A', 'B', 'B' }, 0, 4)]
    [DataRow(new[] { 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'C', 'C' }, 2, 11)]
    [DataRow(new[] { 'A', 'B', 'C', 'D', 'E', 'F' }, 10, 6)]
    [DataRow(new[] { 'A', 'A', 'A', 'A', 'A', 'A' }, 2, 16)]
    [DataRow(new[] { 'A', 'A', 'A', 'B', 'B', 'B', 'C', 'C', 'C' }, 2, 9)]
    [DataRow(new[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 0, 6)]
    [DataRow(new[] { 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'C', 'C', 'D' }, 3, 13)]
    [DataRow(new[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 100, 204)]
    [DataRow(new[] { 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'C', 'D', 'E', 'F', 'G' }, 2, 16)]
    [DataRow(new[] { 'A', 'B', 'C', 'A', 'B', 'C', 'A', 'B', 'C' }, 3, 11)]
    [DataRow(new[] { 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'C', 'D', 'E', 'F', 'G' }, 1, 17)]
    [DataRow(new[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' }, 100, 26)]
    [DynamicData(nameof(GetLargeTestData))]
    public void LeastInterval_GivenTasksAndCooldownPeriod_ReturnsMinimumIntervalsNeeded(char[] tasks, int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LeastInterval(tasks, n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetLargeTestData()
    {
        yield return [BuildTasks(10000, 1), 100, 1009900];

        yield return [BuildTasks(10000, 26), 100, 38800];

        yield return [BuildTasks(10000, 2), 100, 504901];

        yield return [BuildTasks(10000, 26), 0, 10000];
    }

    private static char[] BuildTasks(int length, int distinctCount)
    {
        var tasks = new char[length];

        for (var i = 0; i < length; i++)
        {
            tasks[i] = (char)('A' + (i % distinctCount));
        }

        return tasks;
    }
}