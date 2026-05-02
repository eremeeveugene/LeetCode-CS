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

using LeetCode.Algorithms.RotatedDigits;

namespace LeetCode.Tests.Algorithms.RotatedDigits;

public abstract class RotatedDigitsTestsBase<T> where T : IRotatedDigits, new()
{
    [TestMethod]
    [DataRow(1, 0)]
    [DataRow(2, 1)]
    [DataRow(3, 1)]
    [DataRow(4, 1)]
    [DataRow(5, 2)]
    [DataRow(6, 3)]
    [DataRow(7, 3)]
    [DataRow(8, 3)]
    [DataRow(9, 4)]
    [DataRow(10, 4)]
    [DataRow(11, 4)]
    [DataRow(12, 5)]
    [DataRow(15, 6)]
    [DataRow(20, 9)]
    [DataRow(25, 12)]
    [DataRow(50, 16)]
    [DataRow(100, 40)]
    [DataRow(857, 247)]
    [DataRow(1000, 316)]
    [DataRow(10000, 2320)]
    public void RotatedDigits_WithUpperBound_ReturnsCountOfGoodIntegersInRange(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RotatedDigits(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}