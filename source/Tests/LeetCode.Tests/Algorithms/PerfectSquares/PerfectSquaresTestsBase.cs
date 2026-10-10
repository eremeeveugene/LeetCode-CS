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

using LeetCode.Algorithms.PerfectSquares;

namespace LeetCode.Tests.Algorithms.PerfectSquares;

public abstract class PerfectSquaresTestsBase<T> where T : IPerfectSquares, new()
{
    [TestMethod]
    [DataRow(3, 3)]
    [DataRow(12, 3)]
    [DataRow(13, 2)]
    [DataRow(1, 1)]
    [DataRow(2, 2)]
    [DataRow(4, 1)]
    [DataRow(5, 2)]
    [DataRow(7, 4)]
    [DataRow(8, 2)]
    [DataRow(9, 1)]
    [DataRow(10, 2)]
    [DataRow(15, 4)]
    [DataRow(16, 1)]
    [DataRow(23, 4)]
    [DataRow(25, 1)]
    [DataRow(26, 2)]
    [DataRow(50, 2)]
    [DataRow(100, 1)]
    [DataRow(1000, 2)]
    [DataRow(7168, 4)]
    [DataRow(9999, 4)]
    [DataRow(10000, 1)]
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