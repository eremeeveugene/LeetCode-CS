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

using LeetCode.Algorithms.MinimumTimeToVisitCellInGrid;

namespace LeetCode.Tests.Algorithms.MinimumTimeToVisitCellInGrid;

public abstract class MinimumTimeToVisitCellInGridTestsBase<T> where T : IMinimumTimeToVisitCellInGrid, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinimumTime_GridWithTraversalConstraints_ReturnsTimeToReachBottomRightOrNegativeOne(int[][] grid, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumTime(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 0, 1 }, new[] { 1, 2 } }, 2];

        yield return [new[] { new[] { 0, 1, 3, 2 }, new[] { 5, 1, 2, 5 }, new[] { 4, 3, 8, 6 } }, 7];

        yield return [new[] { new[] { 0, 2, 4 }, new[] { 3, 2, 1 }, new[] { 1, 0, 4 } }, -1];
        yield return [new[] { new[] { 0, 0 }, new[] { 0, 0 } }, 2];
        yield return [new[] { new[] { 0, 1 }, new[] { 1, 0 } }, 2];
        yield return [new[] { new[] { 0, 2 }, new[] { 2, 0 } }, -1];
        yield return [new[] { new[] { 0, 1 }, new[] { 100000, 100000 } }, 100000];
        yield return [new[] { new[] { 0, 100000 }, new[] { 100000, 100000 } }, -1];
        yield return [new[] { new[] { 0, 0 }, new[] { 10, 7 }, new[] { 0, 12 }, new[] { 4, 0 }, new[] { 4, 9 } }, 15];
        yield return [new[] { new[] { 0, 1, 5, 8 }, new[] { 7, 8, 1, 10 }, new[] { 10, 1, 9, 9 } }, 11];
        yield return [new[] { new[] { 0, 0, 1 }, new[] { 1, 6, 9 }, new[] { 1, 8, 10 } }, 10];
        yield return [new[] { new[] { 0, 1 }, new[] { 12, 6 }, new[] { 8, 7 } }, 7];
        yield return [new[] { new[] { 0, 0, 4, 2, 0 }, new[] { 6, 6, 10, 7, 0 }, new[] { 7, 3, 6, 9, 9 }, new[] { 5, 1, 2, 1, 1 }, new[] { 3, 10, 2, 10, 12 } }, 12];
        yield return [new[] { new[] { 0, 1, 9 }, new[] { 9, 12, 8 }, new[] { 8, 7, 5 }, new[] { 4, 5, 7 } }, 13];
        yield return [new[] { new[] { 0, 0, 8, 1, 12 }, new[] { 4, 6, 5, 12, 0 }, new[] { 11, 9, 12, 9, 3 }, new[] { 9, 0, 2, 11, 9 }, new[] { 4, 8, 1, 11, 12 } }, 14];
        yield return [new[] { new[] { 0, 1, 4 }, new[] { 2, 9, 5 } }, 5];
        yield return [new[] { new[] { 0, 0, 1, 9 }, new[] { 1, 11, 9, 3 }, new[] { 8, 11, 10, 2 } }, 11];
        yield return [new[] { new[] { 0, 12, 3 }, new[] { 4, 1, 11 }, new[] { 1, 11, 1 }, new[] { 4, 0, 7 } }, -1];
        yield return [new[] { new[] { 0, 4, 0, 2 }, new[] { 4, 6, 0, 8 }, new[] { 4, 0, 4, 1 }, new[] { 11, 9, 2, 5 } }, -1];
        yield return [new[] { new[] { 0, 1, 5 }, new[] { 8, 0, 4 } }, 5];
        yield return [new[] { new[] { 0, 1, 3, 0 }, new[] { 10, 1, 2, 9 }, new[] { 6, 8, 0, 2 } }, 5];
        yield return [new[] { new[] { 0, 1 }, new[] { 5, 4 }, new[] { 8, 12 } }, 13];

        var largeGrid = new int[300][];

        for (var i = 0; i < 300; i++)
        {
            largeGrid[i] = new int[333];
        }

        yield return [largeGrid, 631];
    }
}