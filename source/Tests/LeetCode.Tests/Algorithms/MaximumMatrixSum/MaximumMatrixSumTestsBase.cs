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

using LeetCode.Algorithms.MaximumMatrixSum;

namespace LeetCode.Tests.Algorithms.MaximumMatrixSum;

public abstract class MaximumMatrixSumTestsBase<T> where T : IMaximumMatrixSum, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaxMatrixSum_WithMatrix_ReturnsMaximumSumAfterFlips(int[][] matrix, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxMatrixSum(matrix);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, -1 }, new[] { -1, 1 } }, 4L];

        yield return [new[] { new[] { 1, 2, 3 }, new[] { -1, -2, -3 }, new[] { 1, 2, 3 } }, 16L];
    }
}