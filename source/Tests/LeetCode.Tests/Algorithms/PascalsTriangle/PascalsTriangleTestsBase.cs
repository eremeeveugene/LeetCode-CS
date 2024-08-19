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

using LeetCode.Algorithms.PascalsTriangle;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.PascalsTriangle;

public abstract class PascalsTriangleTestsBase<T> where T : IPascalsTriangle, new()
{
    [TestMethod]
    [DataRow(1, "[[1]]")]
    [DataRow(5, "[[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]")]
    public void Generate_GivenNumRows_ReturnsPascalsTriangle(int numRows, string expectedJsonResult)
    {
        // Arrange
        var expectedResult = JsonHelper<int>.DeserializeToJaggedList(expectedJsonResult);

        var solution = new T();

        // Act
        var actualResult = solution.Generate(numRows);

        // Assert
        JaggedListAssert.AreEqual(expectedResult, actualResult);
    }
}