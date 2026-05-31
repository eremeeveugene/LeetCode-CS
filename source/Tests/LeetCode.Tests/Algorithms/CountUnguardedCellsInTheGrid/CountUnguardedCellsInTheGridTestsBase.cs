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
    public void CountUnguarded_WithGridSizeGuardsAndWalls_ReturnsNumberOfUnguardedCells(int m, int n, int[][] guards, int[][] words, int expectedResult)
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

        // 1x1 grid: single guard, no unguarded
        yield return [1, 1, new[] { new[] { 0, 0 } }, new int[0][], 0];

        // 1x1 grid: single wall, no unguarded
        yield return [1, 1, new int[0][], new[] { new[] { 0, 0 } }, 0];

        // 1x1 grid: empty, 1 unguarded
        yield return [1, 1, new int[0][], new int[0][], 1];

        // 1x3 grid: guard in middle, walls at ends
        yield return [1, 3, new[] { new[] { 0, 1 } }, new[] { new[] { 0, 0 }, new[] { 0, 2 } }, 0];

        // 1x3 grid: guard at left end
        yield return [1, 3, new[] { new[] { 0, 0 } }, new int[0][], 0];

        // 2x2 grid: guard at 0,0, no walls
        yield return [2, 2, new[] { new[] { 0, 0 } }, new int[0][], 1];

        // 2x2 grid: guard at 0,0, wall at 0,1
        yield return [2, 2, new[] { new[] { 0, 0 } }, new[] { new[] { 0, 1 } }, 2];

        // 3x3 grid: guard at corner, no walls
        yield return [3, 3, new[] { new[] { 0, 0 } }, new int[0][], 4];

        // 3x3 grid: no guards, no walls
        yield return [3, 3, new int[0][], new int[0][], 9];

        // 3x3 grid: guard at center, no walls
        yield return [3, 3, new[] { new[] { 1, 1 } }, new int[0][], 0];

        // 4x4 grid: guard at top-left, wall blocking
        yield return [4, 4, new[] { new[] { 0, 0 } }, new[] { new[] { 0, 2 } }, 7];

        // 2x5 grid: two guards at ends of row
        yield return [2, 5, new[] { new[] { 0, 0 }, new[] { 0, 4 } }, new int[0][], 0];

        // 5x5 grid: four corner guards
        yield return [5, 5, new[] { new[] { 0, 0 }, new[] { 0, 4 }, new[] { 4, 0 }, new[] { 4, 4 } }, new int[0][], 1];

        // 3x5 grid: guards and walls scenario
        yield return [3, 5, new[] { new[] { 0, 2 } }, new[] { new[] { 1, 2 } }, 8];

        // 5x1 grid: guard at center
        yield return [5, 1, new[] { new[] { 2, 0 } }, new int[0][], 0];

        // 4x4 grid: all cells guarded by two guards
        yield return [4, 4, new[] { new[] { 0, 0 }, new[] { 3, 3 } }, new int[0][], 0];

        // 4x6 grid: guard blocked by wall, larger area
        yield return [4, 6, new[] { new[] { 0, 3 } }, new[] { new[] { 2, 3 } }, 11];

        // 2x2 grid: two guards cover all
        yield return [2, 2, new[] { new[] { 0, 0 }, new[] { 1, 1 } }, new int[0][], 0];
    }
}