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

using LeetCode.Algorithms.SpecialPositionsInBinaryMatrix;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SpecialPositionsInBinaryMatrix;

public abstract class SpecialPositionsInBinaryMatrixTestsBase<T> where T : ISpecialPositionsInBinaryMatrix, new()
{
    [TestMethod]
    [DataRow("[[1,0,0],[0,0,1],[1,0,0]]", 1)]
    [DataRow("[[1,0,0],[0,1,0],[0,0,1]]", 3)]
    public void NumSpecial_WithBinaryMatrix_ReturnsCountOfSpecialPositions(string matrixJson, int expectedResult)
    {
        // Arrange
        var mat = JsonHelper.Parse<int[][]>(matrixJson);

        var solution = new T();

        // Act
        var actualResult = solution.NumSpecial(mat);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}