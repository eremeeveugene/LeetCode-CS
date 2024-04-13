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

using LeetCode.Algorithms.MaximalRectangle;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximalRectangle;

public abstract class MaximalRectangleTestsBase<T> where T : IMaximalRectangle, new()
{
    [TestMethod]
    [DataRow("[[\"0\"]]", 0)]
    [DataRow("[[\"1\"]]", 1)]
    [DataRow("[[\"1\",\"0\",\"1\",\"0\",\"0\"],[\"1\",\"0\",\"1\",\"1\",\"1\"],[\"1\",\"1\",\"1\",\"1\",\"1\"],[\"1\",\"0\",\"0\",\"1\",\"0\"]]", 6)]
    public void MaximalRectangle_GivenMatrix_ReturnsMaximalArea(string matrixJsonArray, int expectedResult)
    {
        // Arrange
        var solution = new T();

        var matrix = JsonConvertHelper<char>.JsonArrayToJaggedArray(matrixJsonArray);

        // Act
        var actualResult = solution.MaximalRectangle(matrix);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}