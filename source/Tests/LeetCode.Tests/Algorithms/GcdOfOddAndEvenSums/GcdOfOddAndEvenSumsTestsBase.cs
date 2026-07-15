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

using LeetCode.Algorithms.GcdOfOddAndEvenSums;

namespace LeetCode.Tests.Algorithms.GcdOfOddAndEvenSums;

public abstract class GcdOfOddAndEvenSumsTestsBase<T> where T : IGcdOfOddAndEvenSums, new()
{
    [TestMethod]
    [DataRow(1, 1)]
    [DataRow(2, 2)]
    [DataRow(3, 3)]
    [DataRow(4, 4)]
    [DataRow(5, 5)]
    [DataRow(6, 6)]
    [DataRow(7, 7)]
    [DataRow(8, 8)]
    [DataRow(9, 9)]
    [DataRow(10, 10)]
    [DataRow(15, 15)]
    [DataRow(20, 20)]
    [DataRow(42, 42)]
    [DataRow(50, 50)]
    [DataRow(99, 99)]
    [DataRow(100, 100)]
    [DataRow(123, 123)]
    [DataRow(250, 250)]
    [DataRow(500, 500)]
    [DataRow(777, 777)]
    [DataRow(999, 999)]
    [DataRow(1000, 1000)]
    public void GcdOfOddEvenSums_WithPositiveInteger_ReturnsGreatestCommonDivisor(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.GcdOfOddEvenSums(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}