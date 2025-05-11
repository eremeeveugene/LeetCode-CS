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

using LeetCode.Algorithms.MaximumNumberOfTasksYouCanAssign;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximumNumberOfTasksYouCanAssign;

public abstract class MaximumNumberOfTasksYouCanAssignTestsBase<T>
    where T : IMaximumNumberOfTasksYouCanAssign, new()
{
    [TestMethod]
    [DataRow("[3,2,1]", "[0,3,3]", 1, 1, 3)]
    [DataRow("[5,4]", "[0,0,0]", 1, 5, 1)]
    [DataRow("[10,15,30]", "[0,10,10,10,10]", 3, 10, 2)]
    [DataRow("[5,9,8,5,9]", "[1,6,4,2,6]", 1, 5, 3)]
    public void MaxTaskAssign_WithGivenTasksWorkersPillsAndStrength_ReturnsMaxAssignableTasks(string tasksJson,
        string workersJson, int pills, int strength, int expectedResult)
    {
        // Arrange
        var tasks = JsonHelper<int[]>.Parse(tasksJson);
        var workers = JsonHelper<int[]>.Parse(workersJson);

        var solution = new T();

        // Act
        var actualResult = solution.MaxTaskAssign(tasks, workers, pills, strength);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}