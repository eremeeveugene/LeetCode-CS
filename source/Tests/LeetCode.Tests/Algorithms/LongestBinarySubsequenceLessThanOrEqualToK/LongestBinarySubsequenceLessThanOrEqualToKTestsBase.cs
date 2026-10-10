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

using LeetCode.Algorithms.LongestBinarySubsequenceLessThanOrEqualToK;

namespace LeetCode.Tests.Algorithms.LongestBinarySubsequenceLessThanOrEqualToK;

public abstract class LongestBinarySubsequenceLessThanOrEqualToKTestsBase<T> where T : ILongestBinarySubsequenceLessThanOrEqualToK, new()
{
    [TestMethod]
    [DataRow("1001010", 5, 5)]
    [DataRow("00101001", 1, 6)]
    [DataRow("0", 1, 1)]
    [DataRow("1", 1, 1)]
    [DataRow("1", 2, 1)]
    [DataRow("0", 5, 1)]
    [DataRow("00000", 1, 5)]
    [DataRow("11111", 1, 1)]
    [DataRow("11111", 31, 5)]
    [DataRow("11111", 30, 4)]
    [DataRow("10101", 5, 4)]
    [DataRow("10101", 21, 5)]
    [DataRow("101010", 10, 5)]
    [DataRow("1110111", 6, 3)]
    [DataRow("0001", 1, 4)]
    [DataRow("1000", 7, 3)]
    [DataRow("111000111", 1000000000, 9)]
    [DataRow("1001001001", 100, 9)]
    [DataRow("11111111111111111111", 1000000000, 20)]
    [DataRow("1111111111111111111100000", 1000, 10)]
    public void LongestSubsequence_WithBinaryStringAndLimitK_ReturnsMaxValidSubsequenceLength(string s, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LongestSubsequence(s, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}