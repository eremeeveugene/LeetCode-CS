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

using LeetCode.Algorithms.ProcessTasksUsingServers;

namespace LeetCode.Tests.Algorithms.ProcessTasksUsingServers;

public abstract class ProcessTasksUsingServersTestsBase<T> where T : IProcessTasksUsingServers, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 3, 2 }, new[] { 1, 2, 3, 2, 1, 2 }, new[] { 2, 2, 0, 2, 1, 2 })]
    [DataRow(new[] { 5, 1, 4, 3, 2 }, new[] { 2, 1, 2, 4, 5, 2, 1 }, new[] { 1, 4, 1, 4, 1, 3, 2 })]
    [DataRow(new[] { 1 }, new[] { 1 }, new[] { 0 })]
    [DataRow(new[] { 1 }, new[] { 1, 1, 1 }, new[] { 0, 0, 0 })]
    [DataRow(new[] { 1 }, new[] { 5, 1, 1 }, new[] { 0, 0, 0 })]
    [DataRow(new[] { 1 }, new[] { 200000, 200000 }, new[] { 0, 0 })]
    [DataRow(new[] { 2, 1 }, new[] { 1, 1, 1 }, new[] { 1, 1, 1 })]
    [DataRow(new[] { 2, 1 }, new[] { 3, 3, 3 }, new[] { 1, 0, 1 })]
    [DataRow(new[] { 2, 1 }, new[] { 5, 5, 1, 1 }, new[] { 1, 0, 1, 1 })]
    [DataRow(new[] { 1, 1, 1 }, new[] { 10, 10, 10 }, new[] { 0, 1, 2 })]
    [DataRow(new[] { 1, 1, 1 }, new[] { 10, 10, 10, 10 }, new[] { 0, 1, 2, 0 })]
    [DataRow(new[] { 3, 2, 1 }, new[] { 1, 1, 1 }, new[] { 2, 2, 2 })]
    [DataRow(new[] { 3, 2, 1 }, new[] { 2, 2, 2 }, new[] { 2, 1, 2 })]
    [DataRow(new[] { 3, 2, 1 }, new[] { 5, 5, 5, 5 }, new[] { 2, 1, 0, 2 })]
    [DataRow(new[] { 1, 1 }, new[] { 2, 1, 3 }, new[] { 0, 1, 0 })]
    [DataRow(new[] { 1, 5 }, new[] { 3, 1, 5, 1 }, new[] { 0, 1, 1, 0 })]
    [DataRow(new[] { 10, 20, 30 }, new[] { 1 }, new[] { 0 })]
    [DataRow(new[] { 30, 20, 10 }, new[] { 1, 2 }, new[] { 2, 2 })]
    [DataRow(new[] { 4, 4, 4, 4 }, new[] { 1, 1, 1, 1 }, new[] { 0, 0, 0, 0 })]
    [DataRow(new[] { 4, 4, 4, 4 }, new[] { 4, 4, 4, 4, 4, 4 }, new[] { 0, 1, 2, 3, 0, 1 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 3, 1, 1, 1 }, new[] { 0, 1, 1, 0 })]
    [DataRow(new[] { 2, 3, 1, 2 }, new[] { 1, 3, 2, 1, 1 }, new[] { 2, 2, 0, 3, 2 })]
    [DataRow(new[] { 5, 5 }, new[] { 1, 3, 1, 1 }, new[] { 0, 0, 1, 1 })]
    [DataRow(new[] { 1, 2 }, new[] { 10, 9, 1, 1, 1 }, new[] { 0, 1, 0, 1, 0 })]
    public void AssignTasks_WithServersAndTasks_ReturnsAssignedServerIndices(int[] servers, int[] tasks, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.AssignTasks(servers, tasks);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}