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

using LeetCode.Algorithms.FlipColumnsForMaximumNumberOfEqualRows;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FlipColumnsForMaximumNumberOfEqualRows;

public abstract class FlipColumnsForMaximumNumberOfEqualRowsTestsBase<T>
    where T : IFlipColumnsForMaximumNumberOfEqualRows, new()
{
    [TestMethod]
    [DataRow("[[0,1],[1,1]]", 1)]
    [DataRow("[[0,1],[1,0]]", 2)]
    [DataRow("[[0,0,0],[0,0,1],[1,1,0]]", 2)]
    public void MaxEqualRowsAfterFlips_WithMatrix_ReturnsMaxRowsAfterFlips(string matrixJsonArray, int expectedResult)
    {
        // Arrange
        var matrix = JsonHelper<int>.DeserializeToJaggedArray(matrixJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MaxEqualRowsAfterFlips(matrix);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}