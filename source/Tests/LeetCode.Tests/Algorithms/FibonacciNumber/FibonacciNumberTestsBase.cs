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

using LeetCode.Algorithms.FibonacciNumber;

namespace LeetCode.Tests.Algorithms.FibonacciNumber;

public abstract class FibonacciNumberTestsBase<T> where T : IFibonacciNumber, new()
{
    [TestMethod]
    [DataRow(0, 0)]
    [DataRow(1, 1)]
    [DataRow(2, 1)]
    [DataRow(3, 2)]
    [DataRow(4, 3)]
    [DataRow(5, 5)]
    [DataRow(6, 8)]
    [DataRow(7, 13)]
    [DataRow(8, 21)]
    [DataRow(9, 34)]
    [DataRow(10, 55)]
    [DataRow(11, 89)]
    [DataRow(12, 144)]
    [DataRow(13, 233)]
    [DataRow(14, 377)]
    [DataRow(15, 610)]
    [DataRow(20, 6765)]
    [DataRow(25, 75025)]
    [DataRow(29, 514229)]
    [DataRow(30, 832040)]
    public void Fib_WithInputN_ReturnsNthFibonacciNumber(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Fib(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}