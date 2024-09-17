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

using LeetCode.Algorithms.PascalsTriangle2;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.PascalsTriangle2;

public abstract class PascalsTriangle2TestsBase<T> where T : IPascalsTriangle2, new()
{
    [TestMethod]
    [DataRow(0, "[1]")]
    [DataRow(1, "[1,1]")]
    [DataRow(3, "[1,3,3,1]")]
    public void GetRow_GivenRowIndex_ReturnsPascalsTriangleRow(int rowIndex, string expectedResultJsonArray)
    {
        // Arrange
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.GetRow(rowIndex);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult.ToArray());
    }
}