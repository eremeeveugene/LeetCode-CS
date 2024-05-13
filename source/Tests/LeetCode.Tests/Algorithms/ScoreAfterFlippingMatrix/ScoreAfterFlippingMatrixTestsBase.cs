// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.ScoreAfterFlippingMatrix;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ScoreAfterFlippingMatrix;

public abstract class ScoreAfterFlippingMatrixTestsBase<T> where T : IScoreAfterFlippingMatrix, new()
{
    [TestMethod]
    [DataRow("[[0]]", 1)]
    [DataRow("[[0],[1]]", 2)]
    [DataRow("[[0,0,1,1],[1,0,1,0],[1,1,0,0]]", 39)]
    [DataRow("[[0,1,1,1,1,1,0,1,0,0]]", 1023)]
    [DataRow("[[1,0,1,1,1,0,1,0,1,0],[1,0,0,0,1,1,1,1,0,0]]", 1832)]
    [DataRow("[[0],[1],[1],[0],[0],[1],[0],[1],[0],[0],[1],[1],[0],[0],[0],[1],[0],[1],[0],[0]]", 20)]
    public void MatrixScore_WithJsonArrayInput_ReturnsExpectedScore(string gridJsonArray, int expectedResult)
    {
        // Arrange
        var solution = new T();

        var grid = JsonConvertHelper<int>.JsonArrayToJaggedArray(gridJsonArray);

        // Act
        var actualResult = solution.MatrixScore(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}