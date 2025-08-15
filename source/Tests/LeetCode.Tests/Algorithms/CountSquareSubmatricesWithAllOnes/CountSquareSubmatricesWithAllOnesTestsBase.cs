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

using LeetCode.Algorithms.CountSquareSubmatricesWithAllOnes;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CountSquareSubmatricesWithAllOnes;

public abstract class CountSquareSubmatricesWithAllOnesTestsBase<T> where T : ICountSquareSubmatricesWithAllOnes, new()
{
    [TestMethod]
    [DataRow("[[0,1,1,1],[1,1,1,1],[0,1,1,1]]", 15)]
    [DataRow("[[1,0,1],[1,1,0],[1,1,0]]", 7)]
    public void CountSquares_WithMatrixContainingOnesAndZeros_ReturnsTotalSquareSubmatricesWithAllOnes(
        string matrixJson, int expectedResult)
    {
        // Arrange
        var matrix = JsonHelper<int[][]>.Parse(matrixJson);

        var solution = new T();

        // Act
        var actualResult = solution.CountSquares(matrix);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}