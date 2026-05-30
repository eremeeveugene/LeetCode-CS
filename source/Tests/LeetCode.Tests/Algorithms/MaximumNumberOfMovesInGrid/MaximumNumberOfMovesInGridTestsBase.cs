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

using LeetCode.Algorithms.MaximumNumberOfMovesInGrid;

namespace LeetCode.Tests.Algorithms.MaximumNumberOfMovesInGrid;

public abstract class MaximumNumberOfMovesInGridTestsBase<T> where T : IMaximumNumberOfMovesInGrid, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaxMoves_WithGridInput_ReturnsMaximumMoves(int[][] grid, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxMoves(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 2, 4, 3, 5 }, new[] { 5, 4, 9, 3 }, new[] { 3, 4, 2, 11 }, new[] { 10, 9, 13, 15 } }, 3];

        yield return [new[] { new[] { 3, 2, 4 }, new[] { 2, 1, 9 }, new[] { 1, 1, 7 } }, 0];
    }
}