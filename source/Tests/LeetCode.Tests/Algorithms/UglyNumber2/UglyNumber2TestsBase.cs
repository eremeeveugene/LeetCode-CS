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

using LeetCode.Algorithms.UglyNumber2;

namespace LeetCode.Tests.Algorithms.UglyNumber2;

public abstract class UglyNumber2TestsBase<T> where T : IUglyNumber2, new()
{
    [TestMethod]
    [DataRow(2, 2)]
    [DataRow(3, 3)]
    [DataRow(4, 4)]
    [DataRow(5, 5)]
    [DataRow(6, 6)]
    [DataRow(9, 10)]
    [DataRow(11, 15)]
    [DataRow(12, 16)]
    [DataRow(15, 24)]
    [DataRow(20, 36)]
    [DataRow(25, 54)]
    [DataRow(30, 80)]
    [DataRow(100, 1536)]
    [DataRow(1000, 51200000)]
    [DataRow(1500, 859963392)]
    [DataRow(1, 1)]
    [DataRow(7, 8)]
    [DataRow(8, 9)]
    [DataRow(10, 12)]
    [DataRow(69, 540)]
    [DataRow(420, 393216)]
    [DataRow(1287, 284765625)]
    [DataRow(1689, 2109375000)]
    [DataRow(1690, 2123366400)]
    public void NthUglyNumber_WithIndexN_ReturnsNthNumberWhoseOnlyPrimeFactorsAreTwoThreeOrFive(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NthUglyNumber(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}