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
    public void MaxTaskAssign_WithGivenTasksWorkersPillsAndStrength_ReturnsMaxAssignableTasks(int[] tasks, int[] workers, int pills, int strength, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxTaskAssign(tasks, workers, pills, strength);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}