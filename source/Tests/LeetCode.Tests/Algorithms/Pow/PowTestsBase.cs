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

using LeetCode.Algorithms.Pow;

namespace LeetCode.Tests.Algorithms.Pow;

public abstract class PowTestsBase<T> where T : IPow, new()
{
    [TestMethod]
    [DataRow(2.00000, 10, 1024.00000)]
    [DataRow(2.10000, 3, 9.26100)]
    [DataRow(2.00000, -2, 0.25000)]
    [DataRow(1.00000, 100000, 1.00000)]
    [DataRow(-1.00000, 99999, -1.00000)]
    [DataRow(-1.00000, 100000, 1.00000)]
    [DataRow(0.50000, 3, 0.12500)]
    [DataRow(2.00000, 0, 1.00000)]
    [DataRow(5.00000, 1, 5.00000)]
    [DataRow(-2.00000, 3, -8.00000)]
    [DataRow(-2.00000, 4, 16.00000)]
    [DataRow(10.00000, -1, 0.10000)]
    [DataRow(2.00000, -3, 0.12500)]
    [DataRow(100.00000, 2, 10000.00000)]
    [DataRow(-100.00000, 3, -1000000.00000)]
    [DataRow(2.00000, 30, 1073741824.00000)]
    [DataRow(0.10000, 2, 0.01000)]
    [DataRow(3.00000, -2, 0.11111)]
    [DataRow(1.50000, 5, 7.59375)]
    [DataRow(0.00000, 5, 0.00000)]
    [DataRow(2.00000, -10, 0.00098)]
    [DataRow(1.00001, 10, 1.00010)]
    public void MyPow_WithBaseAndExponent_ReturnsXToThePowerOfN(double x, int n, double expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MyPow(x, n);

        // Assert
        Assert.AreEqual(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
    }
}