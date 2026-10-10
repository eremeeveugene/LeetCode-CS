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

using LeetCode.Algorithms.SeparateBlackAndWhiteBalls;

namespace LeetCode.Tests.Algorithms.SeparateBlackAndWhiteBalls;

public abstract class SeparateBlackAndWhiteBallsTestsBase<T> where T : ISeparateBlackAndWhiteBalls, new()
{
    [TestMethod]
    [DataRow("101", 1)]
    [DataRow("100", 2)]
    [DataRow("0111", 0)]
    [DataRow("0", 0)]
    [DataRow("1", 0)]
    [DataRow("00", 0)]
    [DataRow("11", 0)]
    [DataRow("01", 0)]
    [DataRow("10", 1)]
    [DataRow("0011", 0)]
    [DataRow("1100", 4)]
    [DataRow("1010", 3)]
    [DataRow("0101", 1)]
    [DataRow("111000", 9)]
    [DataRow("000111", 0)]
    [DataRow("10101010", 10)]
    [DataRow("11111111110000000000", 100)]
    [DataRow("000000000000000", 0)]
    [DataRow("111111111111111", 0)]
    [DataRow("110100", 8)]
    [DataRow("100100100", 12)]
    [DataRow("1011001", 7)]
    public void MinimumSteps_WithBinaryString_ReturnsStepCount(string s, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumSteps(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void MinimumSteps_WithMaxLengthStringOfOnesThenZeros_ReturnsStepCountWithoutOverflow()
    {
        // Arrange
        var solution = new T();

        var chars = new char[100_000];

        for (var i = 0; i < chars.Length; i++)
        {
            chars[i] = i < 50_000 ? '1' : '0';
        }

        var s = new string(chars);

        // Act
        var actualResult = solution.MinimumSteps(s);

        // Assert
        Assert.AreEqual(2_500_000_000L, actualResult);
    }
}