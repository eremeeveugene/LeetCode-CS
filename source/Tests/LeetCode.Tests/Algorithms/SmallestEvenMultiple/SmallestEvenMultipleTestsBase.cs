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

using LeetCode.Algorithms.SmallestEvenMultiple;

namespace LeetCode.Tests.Algorithms.SmallestEvenMultiple;

public abstract class SmallestEvenMultipleTestsBase<T> where T : ISmallestEvenMultiple, new()
{
    [TestMethod]
    [DataRow(5, 10)]
    [DataRow(6, 6)]
    [DataRow(1, 2)]
    [DataRow(2, 2)]
    [DataRow(3, 6)]
    [DataRow(4, 4)]
    [DataRow(7, 14)]
    [DataRow(8, 8)]
    [DataRow(9, 18)]
    [DataRow(10, 10)]
    [DataRow(15, 30)]
    [DataRow(16, 16)]
    [DataRow(25, 50)]
    [DataRow(50, 50)]
    [DataRow(99, 198)]
    [DataRow(100, 100)]
    [DataRow(127, 254)]
    [DataRow(128, 128)]
    [DataRow(149, 298)]
    [DataRow(150, 150)]
    public void SmallestEvenMultiple_WithPositiveInteger_ReturnsSmallestMultipleOfTwoAndN(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SmallestEvenMultiple(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}