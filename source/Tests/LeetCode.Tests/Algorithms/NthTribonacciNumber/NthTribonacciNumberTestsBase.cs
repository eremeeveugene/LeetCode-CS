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

using LeetCode.Algorithms.NthTribonacciNumber;

namespace LeetCode.Tests.Algorithms.NthTribonacciNumber;

public abstract class NthTribonacciNumberTestsBase<T> where T : INthTribonacciNumber, new()
{
    [TestMethod]
    [DataRow(0, 0)]
    [DataRow(1, 1)]
    [DataRow(2, 1)]
    [DataRow(3, 2)]
    [DataRow(4, 4)]
    [DataRow(25, 1389537)]
    public void Tribonacci_WithInputN_ReturnsExpectedValue(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Tribonacci(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}