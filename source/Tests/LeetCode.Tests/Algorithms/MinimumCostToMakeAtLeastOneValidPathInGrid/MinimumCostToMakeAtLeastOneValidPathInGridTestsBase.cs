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

using LeetCode.Algorithms.MinimumCostToMakeAtLeastOneValidPathInGrid;

namespace LeetCode.Tests.Algorithms.MinimumCostToMakeAtLeastOneValidPathInGrid;

public abstract class MinimumCostToMakeAtLeastOneValidPathInGridTestsBase<T> where T : IMinimumCostToMakeAtLeastOneValidPathInGrid, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinCost_WithGridJson_ReturnsMinimumCost(int[][] grid, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinCost(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 1, 1, 1 }, new[] { 2, 2, 2, 2 }, new[] { 1, 1, 1, 1 }, new[] { 2, 2, 2, 2 } }, 3];

        yield return [new[] { new[] { 1, 1, 3 }, new[] { 3, 2, 2 }, new[] { 1, 1, 4 } }, 0];

        yield return [new[] { new[] { 1, 2 }, new[] { 4, 3 } }, 1];

        yield return [new[] { new[] { 1 } }, 0];

        yield return [new[] { new[] { 4 } }, 0];

        yield return [new[] { new[] { 1, 1, 1, 1, 1 } }, 0];

        yield return [new[] { new[] { 2, 2, 2, 2 } }, 3];

        yield return [new[] { new[] { 1 }, new[] { 1 }, new[] { 1 } }, 2];

        yield return [new[] { new[] { 3 }, new[] { 3 }, new[] { 3 } }, 0];

        yield return [new[] { new[] { 4 }, new[] { 4 } }, 1];

        yield return [new[] { new[] { 2 }, new[] { 1 } }, 1];

        yield return [new[] { new[] { 2, 4 }, new[] { 1, 4 } }, 1];

        yield return [new[] { new[] { 3, 4, 2 }, new[] { 1, 4, 3 }, new[] { 4, 2, 1 } }, 1];

        yield return [new[] { new[] { 1, 4, 4, 1 }, new[] { 3, 4, 4, 3 }, new[] { 4, 4, 4, 4 } }, 3];

        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 4, 3 }, new[] { 4, 1, 2 }, new[] { 2, 2, 4 } }, 2];

        yield return [new[] { new[] { 1, 4, 3, 3, 4 }, new[] { 3, 2, 3, 4, 1 }, new[] { 3, 2, 3, 2, 3 }, new[] { 3, 2, 4, 2, 2 }, new[] { 4, 1, 2, 2, 4 } }, 4];

        yield return [new[] { new[] { 4, 2, 3, 4, 4, 4 }, new[] { 4, 2, 3, 4, 3, 3 } }, 5];

        yield return [CreateGrid(100, 100, 1), 99];

        yield return [CreateGrid(100, 100, 2), 198];

        yield return [CreateGrid(100, 100, 3), 99];

        yield return [CreateGrid(100, 100, 4), 198];
    }

    private static int[][] CreateGrid(int rows, int columns, int value)
    {
        var grid = new int[rows][];

        for (var i = 0; i < rows; i++)
        {
            grid[i] = new int[columns];

            for (var j = 0; j < columns; j++)
            {
                grid[i][j] = value;
            }
        }

        return grid;
    }
}