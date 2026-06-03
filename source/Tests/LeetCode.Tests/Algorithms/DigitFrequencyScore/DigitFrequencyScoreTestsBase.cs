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

using LeetCode.Algorithms.DigitFrequencyScore;

namespace LeetCode.Tests.Algorithms.DigitFrequencyScore;

public abstract class DigitFrequencyScoreTestsBase<T> where T : IDigitFrequencyScore, new()
{
    [TestMethod]
    [DataRow(1, 1)]
    [DataRow(5, 5)]
    [DataRow(9, 9)]
    [DataRow(10, 1)]
    [DataRow(11, 2)]
    [DataRow(99, 18)]
    [DataRow(100, 1)]
    [DataRow(101, 2)]
    [DataRow(122, 5)]
    [DataRow(200, 2)]
    [DataRow(555, 15)]
    [DataRow(999, 27)]
    [DataRow(1111, 4)]
    [DataRow(1234, 10)]
    [DataRow(9999, 36)]
    [DataRow(12321, 9)]
    [DataRow(102030, 6)]
    [DataRow(987654, 39)]
    [DataRow(1234567, 28)]
    [DataRow(12345678, 36)]
    [DataRow(123456789, 45)]
    [DataRow(999999999, 81)]
    [DataRow(1000000000, 1)]
    public void DigitFrequencyScore_WithPositiveInteger_ReturnsSumOfDigitsTimesFrequencies(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DigitFrequencyScore(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}