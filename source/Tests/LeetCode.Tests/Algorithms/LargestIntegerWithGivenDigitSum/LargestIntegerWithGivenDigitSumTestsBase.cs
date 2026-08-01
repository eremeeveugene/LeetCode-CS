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

using LeetCode.Algorithms.LargestIntegerWithGivenDigitSum;

namespace LeetCode.Tests.Algorithms.LargestIntegerWithGivenDigitSum;

public abstract class LargestIntegerWithGivenDigitSumTestsBase<T> where T : ILargestIntegerWithGivenDigitSum, new()
{
    [TestMethod]
    [DataRow(2, 9, 90)]
    [DataRow(2, 19, -1)]
    [DataRow(5, 0, 0)]
    [DataRow(1, 0, 0)]
    [DataRow(1, 9, 9)]
    [DataRow(1, 10, -1)]
    [DataRow(3, 0, 0)]
    [DataRow(3, 27, 999)]
    [DataRow(3, 28, -1)]
    [DataRow(5, 45, 99999)]
    [DataRow(5, 46, -1)]
    [DataRow(4, 1, 1000)]
    [DataRow(4, 10, 9100)]
    [DataRow(2, 1, 10)]
    [DataRow(3, 5, 500)]
    [DataRow(2, 0, 0)]
    [DataRow(5, 100, -1)]
    [DataRow(1, 1, 1)]
    [DataRow(4, 36, 9999)]
    [DataRow(4, 37, -1)]
    [DataRow(3, 10, 910)]
    [DataRow(5, 9, 90000)]
    public void LargestNumber_WithNAndS_ReturnsLargestNumber(int n, int s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LargestInteger(n, s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}