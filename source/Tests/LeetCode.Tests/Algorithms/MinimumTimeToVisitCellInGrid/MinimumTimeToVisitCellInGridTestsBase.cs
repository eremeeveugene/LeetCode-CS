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
    public void MinimumTime_GridWithTraversalConstraints_ReturnsTimeToReachBottomRightOrNegativeOne(int[][] grid,
        int expectedResult)
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
    }
}