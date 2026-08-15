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

using LeetCode.Algorithms.CountUnguardedCellsInTheGrid;

namespace LeetCode.Tests.Algorithms.CountUnguardedCellsInTheGrid;

public abstract class CountUnguardedCellsInTheGridTestsBase<T> where T : ICountUnguardedCellsInTheGrid, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void CountUnguarded_WithGridSizeGuardsAndWalls_ReturnsNumberOfUnguardedCells(
        int m,
        int n,
        int[][] guards,
        int[][] words,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountUnguarded(m, n, guards, words);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [4, 6, new[] { new[] { 0, 0 }, new[] { 1, 1 }, new[] { 2, 3 } }, new[] { new[] { 0, 1 }, new[] { 2, 2 }, new[] { 1, 4 } }, 7];

        yield return [3, 3, new[] { new[] { 1, 1 } }, new[] { new[] { 0, 1 }, new[] { 1, 0 }, new[] { 2, 1 }, new[] { 1, 2 } }, 4];

        yield return [1, 1, new[] { new[] { 0, 0 } }, Array.Empty<int[]>(), 0];

        yield return [1, 1, Array.Empty<int[]>(), new[] { new[] { 0, 0 } }, 0];

        yield return [1, 1, Array.Empty<int[]>(), Array.Empty<int[]>(), 1];

        yield return [1, 3, new[] { new[] { 0, 1 } }, new[] { new[] { 0, 0 }, new[] { 0, 2 } }, 0];

        yield return [1, 3, new[] { new[] { 0, 0 } }, Array.Empty<int[]>(), 0];

        yield return [2, 2, new[] { new[] { 0, 0 } }, Array.Empty<int[]>(), 1];

        yield return [2, 2, new[] { new[] { 0, 0 } }, new[] { new[] { 0, 1 } }, 1];

        yield return [3, 3, new[] { new[] { 0, 0 } }, Array.Empty<int[]>(), 4];

        yield return [3, 3, Array.Empty<int[]>(), Array.Empty<int[]>(), 9];

        yield return [3, 3, new[] { new[] { 1, 1 } }, Array.Empty<int[]>(), 4];

        yield return [4, 4, new[] { new[] { 0, 0 } }, new[] { new[] { 0, 2 } }, 10];

        yield return [2, 5, new[] { new[] { 0, 0 }, new[] { 0, 4 } }, Array.Empty<int[]>(), 3];

        yield return [5, 5, new[] { new[] { 0, 0 }, new[] { 0, 4 }, new[] { 4, 0 }, new[] { 4, 4 } }, Array.Empty<int[]>(), 9];

        yield return [3, 5, new[] { new[] { 0, 2 } }, new[] { new[] { 1, 2 } }, 9];

        yield return [5, 1, new[] { new[] { 2, 0 } }, Array.Empty<int[]>(), 0];

        yield return [4, 4, new[] { new[] { 0, 0 }, new[] { 3, 3 } }, Array.Empty<int[]>(), 4];

        yield return [4, 6, new[] { new[] { 0, 3 } }, new[] { new[] { 2, 3 } }, 16];

        yield return [2, 2, new[] { new[] { 0, 0 }, new[] { 1, 1 } }, Array.Empty<int[]>(), 0];

        yield return [3, 3, new[] { new[] { 0, 2 }, new[] { 2, 0 } }, Array.Empty<int[]>(), 1];
    }
}