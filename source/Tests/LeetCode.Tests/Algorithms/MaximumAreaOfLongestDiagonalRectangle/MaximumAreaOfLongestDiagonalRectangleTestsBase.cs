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

using LeetCode.Algorithms.MaximumAreaOfLongestDiagonalRectangle;

namespace LeetCode.Tests.Algorithms.MaximumAreaOfLongestDiagonalRectangle;

public abstract class MaximumAreaOfLongestDiagonalRectangleTestsBase<T> where T : IMaximumAreaOfLongestDiagonalRectangle, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void AreaOfMaxDiagonal_WithDimensionsArray_ReturnsAreaOfRectangleHavingTheLongestDiagonal(int[][] dimensions, double expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.AreaOfMaxDiagonal(dimensions);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 9, 3 }, new[] { 8, 6 } }, 48.0];

        yield return [new[] { new[] { 3, 4 }, new[] { 4, 3 } }, 12.0];

        yield return [new[] { new[] { 2, 6 }, new[] { 5, 1 }, new[] { 3, 10 }, new[] { 8, 4 } }, 30.0];

        yield return
        [
            new[] { new[] { 6, 5 }, new[] { 8, 6 }, new[] { 2, 10 }, new[] { 8, 1 }, new[] { 9, 2 }, new[] { 3, 5 }, new[] { 3, 5 } }, 20.0
        ];
    }
}