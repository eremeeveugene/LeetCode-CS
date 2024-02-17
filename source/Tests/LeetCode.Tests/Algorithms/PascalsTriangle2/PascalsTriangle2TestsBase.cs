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

namespace LeetCode.Tests.Algorithms.PascalsTriangle2;

public abstract class PascalsTriangle2TestsBase<T> where T : IPascalsTriangle2, new()
{
    [TestMethod]
    [DataRow(0, new[] { 1 })]
    [DataRow(1, new[] { 1, 1 })]
    [DataRow(3, new[] { 1, 3, 3, 1 })]
    public void GetRow_GivenRowIndex_ReturnsPascalsTriangleRow(int rowIndex, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.GetRow(rowIndex);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult.ToArray());
    }
}