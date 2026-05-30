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

using LeetCode.Algorithms.GridGame;

namespace LeetCode.Tests.Algorithms.GridGame;

public abstract class GridGameTestsBase<T> where T : IGridGame, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void GridGame_WithInputGrid_ReturnsPointsCollectedBySecondRobot(int[][] grid, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.GridGame(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 2, 5, 4 }, new[] { 1, 5, 1 } }, 4L];

        yield return [new[] { new[] { 3, 3, 1 }, new[] { 8, 5, 2 } }, 4L];

        yield return [new[] { new[] { 1, 3, 1, 15 }, new[] { 1, 3, 3, 1 } }, 7L];
    }
}