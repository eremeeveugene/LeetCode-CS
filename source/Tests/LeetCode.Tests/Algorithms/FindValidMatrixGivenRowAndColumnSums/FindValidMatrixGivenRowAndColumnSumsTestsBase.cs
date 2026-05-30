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

using LeetCode.Algorithms.FindValidMatrixGivenRowAndColumnSums;

namespace LeetCode.Tests.Algorithms.FindValidMatrixGivenRowAndColumnSums;

public abstract class FindValidMatrixGivenRowAndColumnSumsTestsBase<T> where T : IFindValidMatrixGivenRowAndColumnSums, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void RestoreMatrix_WithGivenRowAndColumnSums_ReturnsRestoredMatrix(int[] rowSum, int[] colSum, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RestoreMatrix(rowSum, colSum);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 3, 8 }, new[] { 4, 7 }, new[] { new[] { 3, 0 }, new[] { 1, 7 } }];

        yield return [new[] { 5, 7, 10 }, new[] { 8, 6, 8 }, new[] { new[] { 5, 0, 0 }, new[] { 3, 4, 0 }, new[] { 0, 2, 8 } }];
    }
}