// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.MatrixDiagonalSum;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MatrixDiagonalSum;

public abstract class MatrixDiagonalSumTestsBase<T> where T : IMatrixDiagonalSum, new()
{
    [TestMethod]
    [DataRow("[[1,2,3],[4,5,6],[7,8,9]]", 25)]
    [DataRow("[[1,1,1,1],[1,1,1,1],[1,1,1,1],[1,1,1,1]]", 8)]
    [DataRow("[[5]]", 5)]
    public void DiagonalSum_WithMatrix_ReturnsSumOfDiagonalElements(string matJson, int expectedResult)
    {
        // Arrange
        var mat = JsonHelper<int[][]>.Parse(matJson);

        var solution = new T();

        // Act
        var actualResult = solution.DiagonalSum(mat);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}