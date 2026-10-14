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

namespace LeetCode.Tests.Algorithms.MinimumObstacleRemovalToReachCorner;

public abstract class MinimumObstacleRemovalToReachCornerTestsBase<T> where T : IMinimumObstacleRemovalToReachCorner, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinimumObstacles_WithStartToEndPath_ReturnsMinimumObstaclesToRemove(int[][] grid, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumObstacles(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 0, 1, 1 }, new[] { 1, 1, 0 }, new[] { 1, 1, 0 } }, 2];

        yield return [new[] { new[] { 0, 1, 0, 0, 0 }, new[] { 0, 1, 0, 1, 0 }, new[] { 0, 0, 0, 1, 0 } }, 0];
        yield return [new[] { new[] { 0 } }, 0];
        yield return [new[] { new[] { 0, 0 } }, 0];
        yield return [new[] { new[] { 0 }, new[] { 0 } }, 0];
        yield return [new[] { new[] { 0, 1, 0 } }, 1];
        yield return [new[] { new[] { 0, 1 }, new[] { 1, 0 } }, 1];
        yield return [new[] { new[] { 0, 0 }, new[] { 0, 0 } }, 0];
        yield return [new[] { new[] { 0, 1 }, new[] { 1, 0 }, new[] { 1, 0 }, new[] { 1, 0 }, new[] { 1, 0 } }, 1];
        yield return [new[] { new[] { 0, 0, 1, 0, 0 }, new[] { 0, 0, 0, 1, 1 }, new[] { 0, 1, 1, 1, 0 }, new[] { 0, 0, 0, 1, 1 }, new[] { 0, 0, 0, 1, 0 }, new[] { 1, 0, 0, 0, 0 } }, 0];
        yield return [new[] { new[] { 0, 1, 1, 0 } }, 2];
        yield return [new[] { new[] { 0, 0, 1, 0, 1, 1 }, new[] { 0, 0, 0, 0, 1, 1 }, new[] { 0, 0, 0, 0, 1, 0 }, new[] { 1, 0, 1, 1, 0, 0 }, new[] { 1, 1, 0, 1, 0, 0 } }, 1];
        yield return [new[] { new[] { 0, 1, 1, 1, 1 }, new[] { 0, 0, 1, 0, 1 }, new[] { 0, 0, 1, 0, 1 }, new[] { 0, 1, 0, 1, 0 } }, 2];
        yield return [new[] { new[] { 0, 1, 1, 1, 1 }, new[] { 1, 1, 0, 1, 0 }, new[] { 0, 0, 1, 0, 1 }, new[] { 1, 1, 0, 0, 0 } }, 2];
        yield return [new[] { new[] { 0, 1, 1, 0, 1, 0 } }, 3];
        yield return [new[] { new[] { 0, 1, 1, 0, 0 }, new[] { 1, 0, 0, 1, 1 }, new[] { 1, 1, 1, 0, 0 } }, 2];
        yield return [new[] { new[] { 0, 0 }, new[] { 1, 0 }, new[] { 1, 0 }, new[] { 0, 0 } }, 0];
        yield return [new[] { new[] { 0, 1, 0, 0, 1 }, new[] { 0, 1, 1, 0, 1 }, new[] { 0, 0, 1, 1, 1 }, new[] { 1, 0, 1, 1, 1 }, new[] { 1, 1, 0, 1, 0 }, new[] { 1, 0, 0, 1, 0 } }, 2];
        yield return [new[] { new[] { 0, 1, 1 }, new[] { 0, 1, 0 }, new[] { 1, 1, 1 }, new[] { 1, 0, 1 }, new[] { 0, 1, 1 }, new[] { 1, 0, 0 } }, 3];
        yield return [new[] { new[] { 0, 0, 1 }, new[] { 0, 0, 0 } }, 0];
        yield return [new[] { new[] { 0, 0, 1, 0, 0, 0 }, new[] { 1, 0, 0, 0, 1, 1 }, new[] { 0, 0, 1, 1, 1, 0 }, new[] { 1, 1, 1, 1, 1, 0 }, new[] { 0, 0, 0, 1, 1, 0 } }, 1];
        yield return [new[] { new[] { 0, 1, 0, 1 }, new[] { 0, 1, 0, 0 }, new[] { 1, 0, 1, 0 }, new[] { 0, 1, 0, 1 }, new[] { 1, 0, 0, 0 } }, 2];
        yield return [new[] { new[] { 0, 1, 0 }, new[] { 0, 0, 0 }, new[] { 0, 1, 0 }, new[] { 0, 0, 1 }, new[] { 0, 1, 0 }, new[] { 1, 0, 0 } }, 1];

        var largeGrid = new int[300][];

        for (var i = 0; i < 300; i++)
        {
            largeGrid[i] = new int[333];

            for (var j = 0; j < 333; j++)
            {
                largeGrid[i][j] = 1;
            }
        }

        largeGrid[0][0] = 0;
        largeGrid[299][332] = 0;

        yield return [largeGrid, 630];
    }
}