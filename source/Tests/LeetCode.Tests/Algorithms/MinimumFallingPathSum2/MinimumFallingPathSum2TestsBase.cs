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

using LeetCode.Algorithms.MinimumFallingPathSum2;

namespace LeetCode.Tests.Algorithms.MinimumFallingPathSum2;

public abstract class MinimumFallingPathSum2TestsBase<T> where T : IMinimumFallingPathSum2, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinFallingPathSum_WithGridJson_ReturnsMinimumFallingPathSum(int[][] grid, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinFallingPathSum(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } }, 13];

        yield return [new[] { new[] { 7 } }, 7];
    }
}