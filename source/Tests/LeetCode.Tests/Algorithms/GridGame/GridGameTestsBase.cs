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

        yield return [new[] { new[] { 1 }, new[] { 1 } }, 0L];

        yield return [new[] { new[] { 5 }, new[] { 7 } }, 0L];

        yield return [new[] { new[] { 1, 1 }, new[] { 1, 1 } }, 1L];

        yield return [new[] { new[] { 100000, 100000 }, new[] { 100000, 100000 } }, 100000L];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, 2L];

        yield return [new[] { new[] { 10, 1, 1 }, new[] { 1, 1, 10 } }, 1L];

        yield return [new[] { new[] { 1, 1, 1, 1, 1 }, new[] { 1, 1, 1, 1, 1 } }, 2L];

        yield return [new[] { new[] { 9, 8, 7, 6 }, new[] { 1, 2, 3, 4 } }, 6L];

        yield return [new[] { new[] { 1, 2, 3, 4 }, new[] { 9, 8, 7, 6 } }, 9L];

        yield return [new[] { new[] { 19, 18, 5 }, new[] { 12, 20, 16 } }, 12L];

        yield return [new[] { new[] { 19, 3, 20, 1, 16, 9, 18 }, new[] { 8, 7, 16, 18, 18, 16, 13 } }, 43L];

        yield return [new[] { new[] { 5, 8, 5, 17, 13, 1, 3 }, new[] { 6, 19, 2, 10, 1, 9, 16 } }, 27L];

        yield return [new[] { new[] { 13, 14, 13, 19, 15, 5 }, new[] { 12, 4, 2, 5, 16, 7 } }, 20L];

        yield return [new[] { new[] { 14, 10, 14, 17 }, new[] { 13, 19, 12, 18 } }, 31L];

        yield return [new[] { new[] { 14, 19, 8, 11, 1, 9 }, new[] { 20, 6, 11, 18, 19, 19 } }, 26L];

        yield return [new[] { new[] { 7, 19 }, new[] { 9, 10 } }, 9L];

        yield return [new[] { new[] { 3, 16 }, new[] { 16, 3 } }, 16L];

        yield return [new[] { new[] { 3, 14, 5, 1 }, new[] { 10, 14, 14, 4 } }, 10L];

        yield return [new[] { CreateRow(30), CreateRow(30) }, 1500000L];

        yield return [new[] { CreateRow(50000), CreateRow(50000) }, 2500000000L];
    }

    private static int[] CreateRow(int length)
    {
        var row = new int[length];

        Array.Fill(row, 100000);

        return row;
    }
}