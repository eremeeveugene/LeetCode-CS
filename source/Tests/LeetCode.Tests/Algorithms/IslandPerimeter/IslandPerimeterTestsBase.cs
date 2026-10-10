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

using LeetCode.Algorithms.IslandPerimeter;

namespace LeetCode.Tests.Algorithms.IslandPerimeter;

public abstract class IslandPerimeterTestsBase<T> where T : IIslandPerimeter, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void IslandPerimeter_WithGridInput_ReturnsCalculatedPerimeter(int[][] grid, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IslandPerimeter(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 0, 1, 0, 0 }, new[] { 1, 1, 1, 0 }, new[] { 0, 1, 0, 0 }, new[] { 1, 1, 0, 0 } }, 16];

        yield return [new[] { new[] { 1 } }, 4];

        yield return [new[] { new[] { 1, 0 } }, 4];

        yield return [new[] { new[] { 1, 1 } }, 6];

        yield return [new[] { new[] { 1 }, new[] { 1 } }, 6];

        yield return [new[] { new[] { 1, 1 }, new[] { 1, 1 } }, 8];

        yield return [new[] { new[] { 0, 1 }, new[] { 1, 1 } }, 8];

        yield return [new[] { new[] { 1, 0, 1 }, new[] { 1, 1, 1 } }, 12];

        yield return [new[] { new[] { 0, 0, 0 }, new[] { 0, 1, 0 }, new[] { 0, 0, 0 } }, 4];

        yield return [new[] { new[] { 1, 1, 1 } }, 8];

        yield return [new[] { new[] { 1, 1, 1 }, new[] { 1, 1, 1 }, new[] { 1, 1, 1 } }, 12];

        yield return [new[] { new[] { 0, 1, 0 }, new[] { 1, 1, 1 }, new[] { 0, 1, 0 } }, 12];

        yield return [new[] { new[] { 1, 0 }, new[] { 1, 1 }, new[] { 0, 1 } }, 10];

        yield return [new[] { new[] { 1, 1, 1, 1, 1 } }, 12];

        yield return [new[] { new[] { 1 }, new[] { 1 }, new[] { 1 }, new[] { 1 }, new[] { 1 } }, 12];

        yield return [new[] { new[] { 1, 0, 0, 0 }, new[] { 1, 1, 1, 1 }, new[] { 0, 0, 0, 1 } }, 14];

        yield return [new[] { new[] { 1, 1, 0, 0 }, new[] { 0, 1, 0, 0 }, new[] { 0, 1, 1, 1 }, new[] { 0, 0, 0, 1 } }, 16];

        yield return [new[] { new[] { 0, 0, 0, 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 1, 1, 1, 0 }, new[] { 0, 0, 0, 0, 0, 1, 0, 0 }, new[] { 0, 0, 0, 0, 1, 1, 0, 0 }, new[] { 0, 0, 0, 0, 1, 1, 1, 0 } }, 18];

        yield return [new[] { new[] { 0, 0, 0, 0, 1, 1, 1, 1 }, new[] { 0, 0, 0, 0, 1, 1, 1, 1 }, new[] { 0, 0, 0, 1, 1, 1, 1, 0 }, new[] { 0, 0, 0, 0, 1, 1, 0, 0 }, new[] { 0, 0, 0, 0, 1, 0, 0, 0 } }, 20];

        yield return [new[] { new[] { 1, 0 }, new[] { 1, 1 } }, 8];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 0 }, new[] { 1, 1 }, new[] { 1, 0 } }, 8];

        yield return [new[] { new[] { 1, 1, 1 }, new[] { 1, 1, 1 }, new[] { 1, 1, 1 }, new[] { 1, 1, 0 }, new[] { 0, 0, 0 }, new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }, 14];

        yield return [new[] { new[] { 1, 1, 0, 0, 0, 0, 0 }, new[] { 1, 1, 0, 0, 0, 0, 0 }, new[] { 0, 1, 1, 0, 0, 0, 0 } }, 12];

        yield return [CreateLandGrid(100, 100), 400];

        yield return [CreateLandGrid(1, 100), 202];

        yield return [CreateLandGrid(100, 1), 202];
    }

    private static int[][] CreateLandGrid(int rows, int columns)
    {
        var grid = new int[rows][];

        for (var i = 0; i < rows; i++)
        {
            grid[i] = new int[columns];

            Array.Fill(grid[i], 1);
        }

        return grid;
    }
}