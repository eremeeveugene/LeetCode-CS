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

using LeetCode.Algorithms.MinimumObstacleRemovalToReachCorner;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumObstacleRemovalToReachCorner;

public abstract class MinimumObstacleRemovalToReachCornerTestsBase<T>
    where T : IMinimumObstacleRemovalToReachCorner, new()
{
    [TestMethod]
    [DataRow("[[0,1,1],[1,1,0],[1,1,0]]", 2)]
    [DataRow("[[0,1,0,0,0],[0,1,0,1,0],[0,0,0,1,0]]", 0)]
    public void MinimumObstacles_WithStartToEndPath_ReturnsMinimumObstaclesToRemove(string gridJson,
        int expectedResult)
    {
        // Arrange
        var grid = JsonHelper.Parse<int[][]>(gridJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinimumObstacles(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}