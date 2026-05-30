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

public abstract class MinimumCostToMakeAtLeastOneValidPathInGridTestsBase<T>
    where T : IMinimumCostToMakeAtLeastOneValidPathInGrid, new()
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
        yield return [new int[][] { new[] { 1, 1, 1, 1 }, new[] { 2, 2, 2, 2 }, new[] { 1, 1, 1, 1 }, new[] { 2, 2, 2, 2 } }, 3];

        yield return [new int[][] { new[] { 1, 1, 3 }, new[] { 3, 2, 2 }, new[] { 1, 1, 4 } }, 0];

        yield return [new int[][] { new[] { 1, 2 }, new[] { 4, 3 } }, 1];
    }
}
