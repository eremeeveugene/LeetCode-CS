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

using LeetCode.Algorithms.CountSubIslands;

namespace LeetCode.Tests.Algorithms.CountSubIslands;

public abstract class CountSubIslandsTestsBase<T> where T : ICountSubIslands, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void CountSubIslands_WithTwoBinaryGrids_ReturnsNumberOfSubIslands(int[][] grid1, int[][] grid2,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountSubIslands(grid1, grid2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new[]
            {
                new[] { 1, 1, 1, 0, 0 }, new[] { 0, 1, 1, 1, 1 }, new[] { 0, 0, 0, 0, 0 }, new[] { 1, 0, 0, 0, 0 },
                new[] { 1, 1, 0, 1, 1 }
            },
            new[]
            {
                new[] { 1, 1, 1, 0, 0 }, new[] { 0, 0, 1, 1, 1 }, new[] { 0, 1, 0, 0, 0 }, new[] { 1, 0, 1, 1, 0 },
                new[] { 0, 1, 0, 1, 0 }
            },
            3
        ];

        yield return
        [
            new[]
            {
                new[] { 1, 0, 1, 0, 1 }, new[] { 1, 1, 1, 1, 1 }, new[] { 0, 0, 0, 0, 0 }, new[] { 1, 1, 1, 1, 1 },
                new[] { 1, 0, 1, 0, 1 }
            },
            new[]
            {
                new[] { 0, 0, 0, 0, 0 }, new[] { 1, 1, 1, 1, 1 }, new[] { 0, 1, 0, 1, 0 }, new[] { 0, 1, 0, 1, 0 },
                new[] { 1, 0, 0, 0, 1 }
            },
            2
        ];
    }
}