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

using LeetCode.Algorithms.SwimInRisingWater;

namespace LeetCode.Tests.Algorithms.SwimInRisingWater;

public abstract class SwimInRisingWaterTestsBase<T> where T : ISwimInRisingWater, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SwimInWater_WithElevatedGrid_ReturnsMinimumTimeToReachBottomRight(int[][] grid, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SwimInWater(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 0, 2 }, new[] { 1, 3 } }, 3];

        yield return
        [
            new[]
            {
                new[] { 0, 1, 2, 3, 4 },
                new[] { 24, 23, 22, 21, 5 },
                new[] { 12, 13, 14, 15, 16 },
                new[] { 11, 17, 18, 19, 20 },
                new[] { 10, 9, 8, 7, 6 }
            },
            16
        ];

        yield return
        [
            new[]
            {
                new[] { 0 }
            },
            0
        ];

        yield return
        [
            new[]
            {
                new[] { 1, 0 },
                new[] { 2, 3 }
            },
            3
        ];

        yield return
        [
            new[]
            {
                new[] { 3, 2 },
                new[] { 0, 1 }
            },
            3
        ];

        yield return
        [
            new[]
            {
                new[] { 0, 1 },
                new[] { 2, 3 }
            },
            3
        ];

        yield return
        [
            new[]
            {
                new[] { 0, 3 },
                new[] { 1, 2 }
            },
            2
        ];

        yield return
        [
            new[]
            {
                new[] { 2, 0 },
                new[] { 3, 1 }
            },
            2
        ];

        yield return
        [
            new[]
            {
                new[] { 3, 0, 7 },
                new[] { 4, 5, 8 },
                new[] { 1, 2, 6 }
            },
            6
        ];

        yield return
        [
            new[]
            {
                new[] { 1, 6, 8 },
                new[] { 7, 3, 0 },
                new[] { 5, 4, 2 }
            },
            6
        ];

        yield return
        [
            new[]
            {
                new[] { 15, 3, 6, 14 },
                new[] { 9, 13, 5, 1 },
                new[] { 10, 4, 12, 11 },
                new[] { 7, 2, 8, 0 }
            },
            15
        ];

        yield return
        [
            new[]
            {
                new[] { 14, 13, 4, 6 },
                new[] { 15, 7, 2, 11 },
                new[] { 3, 0, 12, 5 },
                new[] { 10, 8, 1, 9 }
            },
            14
        ];

        yield return
        [
            new[]
            {
                new[] { 0, 14, 3, 16, 22 },
                new[] { 18, 1, 13, 5, 11 },
                new[] { 10, 24, 12, 7, 20 },
                new[] { 2, 6, 23, 17, 8 },
                new[] { 9, 15, 4, 19, 21 }
            },
            21
        ];

        yield return
        [
            new[]
            {
                new[] { 4, 25, 1, 13, 26, 27 },
                new[] { 21, 16, 0, 34, 3, 19 },
                new[] { 23, 22, 18, 35, 30, 29 },
                new[] { 11, 33, 2, 24, 9, 6 },
                new[] { 12, 7, 28, 17, 20, 10 },
                new[] { 31, 8, 5, 15, 14, 32 }
            },
            32
        ];

        yield return
        [
            new[]
            {
                new[] { 22, 28, 4, 1, 40, 15, 3 },
                new[] { 16, 42, 21, 11, 47, 30, 6 },
                new[] { 7, 29, 41, 38, 12, 13, 27 },
                new[] { 43, 17, 8, 0, 46, 32, 37 },
                new[] { 48, 39, 10, 9, 35, 23, 19 },
                new[] { 18, 14, 25, 44, 33, 36, 31 },
                new[] { 34, 24, 26, 45, 20, 5, 2 }
            },
            35
        ];

        yield return
        [
            new[]
            {
                new[] { 0, 1, 2, 3 },
                new[] { 7, 6, 5, 4 },
                new[] { 8, 9, 10, 11 },
                new[] { 15, 14, 13, 12 }
            },
            12
        ];

        yield return
        [
            new[]
            {
                new[] { 8, 7, 6 },
                new[] { 5, 4, 3 },
                new[] { 2, 1, 0 }
            },
            8
        ];

        yield return [BuildLinearGrid(50, 1), 2499];

        yield return [BuildLinearGrid(50, 7), 2493];

        yield return [BuildLinearGrid(50, 1237), 1826];
    }

    private static int[][] BuildLinearGrid(int n, int multiplier)
    {
        var grid = new int[n][];

        for (var i = 0; i < n; i++)
        {
            grid[i] = new int[n];

            for (var j = 0; j < n; j++)
            {
                grid[i][j] = ((i * n) + j) * multiplier % (n * n);
            }
        }

        return grid;
    }
}