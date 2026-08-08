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

using LeetCode.Algorithms.SmallestDivisibleDigitProduct1;

namespace LeetCode.Tests.Algorithms.SmallestDivisibleDigitProduct1;

public abstract class SmallestDivisibleDigitProduct1TestsBase<T> where T : ISmallestDivisibleDigitProduct1, new()
{
    [TestMethod]
    [DataRow(10, 2, 10)]
    [DataRow(15, 3, 16)]
    [DataRow(1, 1, 1)]
    [DataRow(5, 5, 5)]
    [DataRow(7, 3, 9)]
    [DataRow(11, 5, 15)]
    [DataRow(20, 3, 20)]
    [DataRow(21, 4, 22)]
    [DataRow(23, 6, 23)]
    [DataRow(30, 7, 30)]
    [DataRow(99, 3, 99)]
    [DataRow(98, 7, 100)]
    [DataRow(95, 9, 95)]
    [DataRow(91, 9, 91)]
    [DataRow(77, 10, 80)]
    [DataRow(100, 10, 100)]
    [DataRow(55, 4, 58)]
    [DataRow(61, 8, 64)]
    [DataRow(2, 2, 2)]
    [DataRow(9, 9, 9)]
    public void SmallestNumber_WithNAndT_ReturnsSmallestQualifyingNumber(int n, int t, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SmallestNumber(n, t);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}