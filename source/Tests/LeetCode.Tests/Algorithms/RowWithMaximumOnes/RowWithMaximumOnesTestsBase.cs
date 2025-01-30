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

using LeetCode.Algorithms.RowWithMaximumOnes;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.RowWithMaximumOnes;

public abstract class RowWithMaximumOnesTestsBase<T> where T : IRowWithMaximumOnes, new()
{
    [TestMethod]
    [DataRow("[[0,1],[1,0]]", "[0,1]")]
    [DataRow("[[0,0,0],[0,1,1]]", "[1,2]")]
    [DataRow("[[0,0],[1,1],[0,0]]", "[1,2]")]
    public void RowAndMaximumOnes_WithMatrix_ReturnsRowIndexAndMaxOnesCount(string matJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var mat = JsonHelper<int>.DeserializeToJaggedArray(matJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.RowAndMaximumOnes(mat);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}