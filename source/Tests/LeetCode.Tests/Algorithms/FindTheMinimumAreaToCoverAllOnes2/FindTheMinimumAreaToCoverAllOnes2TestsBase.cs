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

using LeetCode.Algorithms.FindTheMinimumAreaToCoverAllOnes2;

namespace LeetCode.Tests.Algorithms.FindTheMinimumAreaToCoverAllOnes2;

public abstract class FindTheMinimumAreaToCoverAllOnes2TestsBase<T> where T : IFindTheMinimumAreaToCoverAllOnes2, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinimumSum_WithBinaryGrid_ReturnsMinimumSumOfRectanglesArea(int[][] grid, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumSum(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 0, 1 }, new[] { 1, 1, 1 } }, 5];

        yield return [new[] { new[] { 1, 0, 1, 0 }, new[] { 0, 1, 0, 1 } }, 5];
    }
}