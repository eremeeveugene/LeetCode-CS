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

public abstract class CountNegativeNumbersInSortedMatrixTestsBase<T>
    where T : ICountNegativeNumbersInSortedMatrix, new()
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

        yield return
        [
            new[] { new[] { 4, 3, 2, -1 }, new[] { 3, 2, 1, -1 }, new[] { 1, 1, -1, -2 }, new[] { -1, -1, -2, -3 } }, 8
        ];
    }
}