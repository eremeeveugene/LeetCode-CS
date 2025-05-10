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

using LeetCode.Algorithms.SetMatrixZeroes;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.SetMatrixZeroes;

public abstract class SetMatrixZeroesTestsBase<T> where T : ISetMatrixZeroes, new()
{
    [TestMethod]
    [DataRow("[[1,1,1],[1,0,1],[1,1,1]]", "[[1,0,1],[0,0,0],[1,0,1]]")]
    [DataRow("[[0,1,2,0],[3,4,5,2],[1,3,1,5]]", "[[0,0,0,0],[0,4,5,0],[0,3,1,0]]")]
    public void SetZeroes_WithMatrixContainingZeros_SetsEntireRowAndColumnToZero(string matrixJson,
        string expectedResultJson)
    {
        // Arrange
        var matrix = JsonHelper<int>.DeserializeToJaggedArray(matrixJson);
        var expectedResult = JsonHelper<int>.DeserializeToJaggedArray(expectedResultJson);

        var solution = new T();

        // Act
        solution.SetZeroes(matrix);

        // Assert
        JaggedArrayAssert.AreEqual(expectedResult, matrix);
    }
}