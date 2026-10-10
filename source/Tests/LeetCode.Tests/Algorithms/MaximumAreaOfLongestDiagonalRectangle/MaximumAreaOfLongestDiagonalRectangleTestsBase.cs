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

        yield return [new[] { new[] { 1, 1 } }, 1.0];

        yield return [new[] { new[] { 100, 100 } }, 10000.0];

        yield return [new[] { new[] { 1, 100 }, new[] { 100, 1 } }, 100.0];

        yield return [new[] { new[] { 6, 8 }, new[] { 10, 1 } }, 10.0];

        yield return [new[] { new[] { 3, 4 }, new[] { 5, 1 }, new[] { 4, 3 } }, 5.0];

        yield return [new[] { new[] { 5, 5 }, new[] { 7, 1 } }, 25.0];

        yield return [new[] { new[] { 2, 2 }, new[] { 2, 2 }, new[] { 2, 2 } }, 4.0];

        yield return [new[] { new[] { 1, 7 }, new[] { 5, 5 } }, 25.0];

        yield return [new[] { new[] { 10, 10 }, new[] { 14, 2 }, new[] { 2, 14 } }, 100.0];

        yield return [new[] { new[] { 8, 9 }, new[] { 9, 8 }, new[] { 6, 10 } }, 72.0];

        yield return [new[] { new[] { 50, 50 }, new[] { 70, 1 } }, 2500.0];

        yield return [new[] { new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 1 } }, 2.0];

        yield return [new[] { new[] { 9, 12 }, new[] { 15, 1 }, new[] { 12, 9 } }, 15.0];

        yield return [new[] { new[] { 20, 21 }, new[] { 29, 1 }, new[] { 21, 20 } }, 29.0];

        yield return [new[] { new[] { 4, 5 }, new[] { 3, 6 }, new[] { 2, 7 } }, 14.0];

        yield return [new[] { new[] { 100, 99 }, new[] { 99, 100 }, new[] { 98, 100 } }, 9900.0];
    }
}