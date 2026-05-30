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

using LeetCode.Algorithms.NumberOfIslands;

namespace LeetCode.Tests.Algorithms.NumberOfIslands;

public abstract class NumberOfIslandsTestsBase<T> where T : INumberOfIslands, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void NumIslands_WithGridOfLandAndWater_ReturnsNumberOfIslands(char[][] grid, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumIslands(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { '1', '1', '1', '1', '0' }, new[] { '1', '1', '0', '1', '0' }, new[] { '1', '1', '0', '0', '0' }, new[] { '0', '0', '0', '0', '0' } }, 1];

        yield return [new[] { new[] { '1', '1', '0', '0', '0' }, new[] { '1', '1', '0', '0', '0' }, new[] { '0', '0', '1', '0', '0' }, new[] { '0', '0', '0', '1', '1' } }, 3];
    }
}