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

using LeetCode.Algorithms.PerfectSquares;

namespace LeetCode.Tests.Algorithms.PerfectSquares;

public abstract class PerfectSquaresTestsBase<T> where T : IPerfectSquares, new()
{
    [TestMethod]
    [DataRow(3, 3)]
    [DataRow(12, 3)]
    [DataRow(13, 2)]
    public void NumSquares_GivenNumber_ReturnsMinimumNumberOfPerfectSquares(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumSquares(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}