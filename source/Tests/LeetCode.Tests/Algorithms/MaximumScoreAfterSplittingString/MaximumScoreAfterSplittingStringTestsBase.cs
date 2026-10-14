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

using LeetCode.Algorithms.MaximumScoreAfterSplittingString;

namespace LeetCode.Tests.Algorithms.MaximumScoreAfterSplittingString;

public abstract class MaximumScoreAfterSplittingStringTestsBase<T> where T : IMaximumScoreAfterSplittingString, new()
{
    [TestMethod]
    [DataRow("1111", 3)]
    [DataRow("011101", 5)]
    [DataRow("00111", 5)]
    [DataRow("00", 1)]
    [DataRow("11", 1)]
    [DataRow("01", 2)]
    [DataRow("10", 0)]
    [DataRow("0000", 3)]
    [DataRow("000111", 6)]
    [DataRow("111000", 2)]
    [DataRow("0101", 3)]
    [DataRow("1010", 2)]
    [DataRow("10101010", 4)]
    [DataRow("0011", 4)]
    [DataRow("1100", 1)]
    [DataRow("00001111", 8)]
    [DataRow("0110110", 5)]
    [DataRow("1000001", 6)]
    [DataRow("0000000001", 10)]
    [DataRow("1111111110", 8)]
    public void MaxScore_WithBinaryString_ReturnsMaximumScore(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxScore(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}