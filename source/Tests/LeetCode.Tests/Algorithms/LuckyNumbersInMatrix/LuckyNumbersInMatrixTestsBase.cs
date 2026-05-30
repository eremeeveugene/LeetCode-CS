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

using LeetCode.Algorithms.LuckyNumbersInMatrix;

namespace LeetCode.Tests.Algorithms.LuckyNumbersInMatrix;

public abstract class LuckyNumbersInMatrixTestsBase<T> where T : ILuckyNumbersInMatrix, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void LuckyNumbers_WithMatrixJson_ReturnsLuckyNumbers(int[][] matrix,
        int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LuckyNumbers(matrix).ToArray();

        // Assert
        CollectionAssert.AreEquivalent(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 3, 7, 8 }, new[] { 9, 11, 13 }, new[] { 15, 16, 17 } }, new[] { 15 }];

        yield return [new[] { new[] { 1, 10, 4, 2 }, new[] { 9, 3, 8, 7 }, new[] { 15, 16, 17, 12 } }, new[] { 12 }];

        yield return [new[] { new[] { 7, 8 }, new[] { 1, 2 } }, new[] { 7 }];
    }
}