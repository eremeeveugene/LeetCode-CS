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

using LeetCode.Algorithms.CountNegativeNumbersInSortedMatrix;

namespace LeetCode.Tests.Algorithms.CountNegativeNumbersInSortedMatrix;

public abstract class CountNegativeNumbersInSortedMatrixTestsBase<T> where T : ICountNegativeNumbersInSortedMatrix, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void CountNegatives_WithSortedMatrix_ReturnsTotalNegativeCount(int[][] grid, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountNegatives(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 3, 2 }, new[] { 1, 0 } }, 0];

        yield return [new[] { new[] { 4, 3, 2, -1 }, new[] { 3, 2, 1, -1 }, new[] { 1, 1, -1, -2 }, new[] { -1, -1, -2, -3 } }, 8];

        yield return [new[] { new[] { 1 } }, 0];

        yield return [new[] { new[] { -1 } }, 1];

        yield return [new[] { new[] { 0 } }, 0];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 0 } }, 0];

        yield return [new[] { new[] { -1, -1 }, new[] { -1, -1 } }, 4];

        yield return [new[] { new[] { 5, 4, 3, 2, 1 } }, 0];

        yield return [new[] { new[] { -1, -2, -3, -4 } }, 4];

        yield return [new[] { new[] { 1 }, new[] { 0 }, new[] { -1 } }, 1];

        yield return [new[] { new[] { 3, -1 }, new[] { -1, -1 } }, 3];

        yield return [new[] { new[] { 100, -100 } }, 1];

        yield return [new[] { new[] { 1, 1, -1 }, new[] { 1, -1, -1 }, new[] { -1, -1, -1 } }, 6];

        yield return [new[] { new[] { 0, -1 }, new[] { -1, -2 } }, 3];

        yield return [new[] { new[] { 5, 3, 3, -2 }, new[] { 3, 2, 1, -3 }, new[] { 2, 1, -1, -3 } }, 4];

        yield return [new[] { new[] { 5, 2, 1, 1, -4 }, new[] { 4, 2, 0, -3, -5 }, new[] { 4, 0, -2, -4, -5 }, new[] { 3, 0, -2, -4, -5 }, new[] { 1, -2, -3, -5, -5 } }, 13];

        yield return [new[] { new[] { 5, 1, -2 }, new[] { 5, 0, -3 }, new[] { 3, -2, -3 }, new[] { 2, -2, -4 }, new[] { 2, -3, -5 }, new[] { 2, -4, -5 } }, 10];

        yield return [new[] { new[] { 5, 4, 4, 3, 3, 0, 0 }, new[] { 5, 4, 3, 3, 2, -1, -2 }, new[] { 5, 4, 3, 1, 1, -2, -3 }, new[] { 4, 4, 2, 0, 0, -2, -4 }, new[] { 3, 2, 1, 0, -1, -3, -4 }, new[] { 3, 2, 0, 0, -3, -4, -4 }, new[] { 2, 1, -1, -3, -4, -5, -5 } }, 17];

        yield return [new[] { new[] { 5, 1, 0, -3, -3, -3, -4, -4 } }, 5];

        yield return [new[] { new[] { 5 }, new[] { 5 }, new[] { 4 }, new[] { 3 }, new[] { 1 }, new[] { -2 }, new[] { -3 }, new[] { -5 } }, 3];
    }
}