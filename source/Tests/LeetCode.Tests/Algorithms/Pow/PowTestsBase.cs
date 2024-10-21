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

using LeetCode.Algorithms.Pow;

namespace LeetCode.Tests.Algorithms.Pow;

public abstract class PowTestsBase<T> where T : IPow, new()
{
    [TestMethod]
    [DataRow(2.00000, 10, 1024.00000)]
    [DataRow(2.10000, 3, 9.26100)]
    [DataRow(2.00000, -2, 0.25000)]
    public void MyPow_WithBaseAndExponent_ReturnsExpectedPower(double x, int n, double expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MyPow(x, n);

        // Assert
        Assert.AreEqual(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
    }
}