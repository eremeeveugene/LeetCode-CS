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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximumMatrixSum;

public abstract class MaximumMatrixSumTestsBase<T> where T : IMaximumMatrixSum, new()
{
    [TestMethod]
    [DataRow("[[1,-1],[-1,1]]", 4)]
    [DataRow("[[1,2,3],[-1,-2,-3],[1,2,3]]", 16)]
    public void MaxMatrixSum_WithMatrix_ReturnsMaximumSumAfterFlips(string matrixJson, long expectedResult)
    {
        // Arrange
        var matrix = JsonHelper.Parse<int[][]>(matrixJson);

        var solution = new T();

        // Act
        var actualResult = solution.MaxMatrixSum(matrix);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}