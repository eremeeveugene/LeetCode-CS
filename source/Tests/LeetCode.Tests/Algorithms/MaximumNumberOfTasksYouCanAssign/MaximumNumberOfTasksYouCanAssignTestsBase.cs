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

using LeetCode.Algorithms.MaximumNumberOfTasksYouCanAssign;

namespace LeetCode.Tests.Algorithms.MaximumNumberOfTasksYouCanAssign;

public abstract class MaximumNumberOfTasksYouCanAssignTestsBase<T> where T : IMaximumNumberOfTasksYouCanAssign, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 2, 1 }, new[] { 0, 3, 3 }, 1, 1, 3)]
    [DataRow(new[] { 5, 4 }, new[] { 0, 0, 0 }, 1, 5, 1)]
    [DataRow(new[] { 10, 15, 30 }, new[] { 0, 10, 10, 10, 10 }, 3, 10, 2)]
    [DataRow(new[] { 5, 9, 8, 5, 9 }, new[] { 1, 6, 4, 2, 6 }, 1, 5, 3)]
    [DataRow(new[] { 1 }, new[] { 1 }, 0, 0, 1)]
    [DataRow(new[] { 1 }, new[] { 0 }, 0, 0, 0)]
    [DataRow(new[] { 1 }, new[] { 0 }, 1, 1, 1)]
    [DataRow(new[] { 5, 4 }, new[] { 0, 0, 0 }, 0, 0, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 }, 0, 0, 5)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 5, 4, 3, 2, 1 }, 0, 0, 5)]
    [DataRow(new[] { 10, 20 }, new[] { 5, 5 }, 2, 10, 1)]
    [DataRow(new[] { 100 }, new[] { 50 }, 1, 50, 1)]
    [DataRow(new[] { 100 }, new[] { 49 }, 1, 50, 0)]
    [DataRow(new[] { 1, 2 }, new[] { 1 }, 0, 0, 1)]
    [DataRow(new[] { 1, 1, 1 }, new[] { 1, 1, 1 }, 0, 0, 3)]
    [DataRow(new[] { 3 }, new[] { 1, 2 }, 1, 2, 1)]
    [DataRow(new[] { 1, 2, 3 }, new[] { 3, 2, 1 }, 0, 0, 3)]
    [DataRow(new[] { 2, 2 }, new[] { 1, 1 }, 2, 1, 2)]
    [DataRow(new[] { 1, 3, 5 }, new[] { 2, 4, 6 }, 0, 0, 3)]
    [DataRow(new[] { 5, 5 }, new[] { 4, 4 }, 0, 0, 0)]
    public void MaxTaskAssign_WithGivenTasksWorkersPillsAndStrength_ReturnsMaxAssignableTasks(
        int[] tasks,
        int[] workers,
        int pills,
        int strength,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxTaskAssign(tasks, workers, pills, strength);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}