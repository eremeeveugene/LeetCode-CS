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

using LeetCode.Algorithms.MinimumPathSum;

namespace LeetCode.Tests.Algorithms.MinimumPathSum;

public abstract class MinimumPathSumTestsBase<T> where T : IMinimumPathSum, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinPathSum_WithGrid_ReturnsMinimumPathSumFromTopLeftToBottomRight(int[][] grid, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinPathSum(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 3, 1 }, new[] { 1, 5, 1 }, new[] { 4, 2, 1 } }, 7];

        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 } }, 12];

        yield return [new[] { new[] { 1 } }, 1];

        yield return [new[] { new[] { 0 } }, 0];

        yield return [new[] { new[] { 200 } }, 200];

        yield return [new[] { new[] { 1, 2 }, new[] { 1, 1 } }, 3];

        yield return [new[] { new[] { 1, 2, 3 } }, 6];

        yield return [new[] { new[] { 1 }, new[] { 2 }, new[] { 3 } }, 6];

        yield return [new[] { new[] { 1, 2, 5 }, new[] { 3, 2, 1 } }, 6];

        yield return [new[] { new[] { 1, 0 }, new[] { 0, 1 } }, 2];

        yield return [new[] { new[] { 2, 2 }, new[] { 2, 2 } }, 6];

        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } }, 21];

        yield return [new[] { new[] { 100, 200 }, new[] { 150, 50 } }, 300];

        yield return [new[] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }, 0];

        yield return [new[] { new[] { 1, 1, 1, 1 } }, 4];

        yield return [new[] { new[] { 3 }, new[] { 1 }, new[] { 4 }, new[] { 1 }, new[] { 5 } }, 14];

        yield return [new[] { new[] { 1, 3 }, new[] { 2, 4 } }, 7];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 } }, 13];

        yield return [new[] { new[] { 9, 9, 9 }, new[] { 9, 1, 9 }, new[] { 9, 1, 9 }, new[] { 9, 1, 1 } }, 22];

        yield return [new[] { new[] { 1, 2, 3, 4, 5 } }, 15];

        yield return [new[] { new[] { 1 }, new[] { 1 }, new[] { 1 }, new[] { 1 }, new[] { 1 } }, 5];

        yield return [new[] { new[] { 5, 4, 2 }, new[] { 1, 9, 1 }, new[] { 8, 1, 3 } }, 15];
    }
}