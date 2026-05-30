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

using LeetCode.Algorithms.MatrixDiagonalSum;

namespace LeetCode.Tests.Algorithms.MatrixDiagonalSum;

public abstract class MatrixDiagonalSumTestsBase<T> where T : IMatrixDiagonalSum, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void DiagonalSum_WithMatrix_ReturnsSumOfDiagonalElements(int[][] mat, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DiagonalSum(mat);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } }, 25];

        yield return [new[] { new[] { 1, 1, 1, 1 }, new[] { 1, 1, 1, 1 }, new[] { 1, 1, 1, 1 }, new[] { 1, 1, 1, 1 } }, 8];

        yield return [new[] { new[] { 5 } }, 5];
    }
}