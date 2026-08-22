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

using LeetCode.Algorithms.CountValidPrefixes;

namespace LeetCode.Tests.Algorithms.CountValidPrefixes;

public abstract class CountValidPrefixesTestsBase<T> where T : ICountValidPrefixes, new()
{
    [TestMethod]
    [DataRow("0", 1)]
    [DataRow("1", 1)]
    [DataRow("00", 1)]
    [DataRow("11", 1)]
    [DataRow("01", 2)]
    [DataRow("10", 2)]
    [DataRow("000", 1)]
    [DataRow("111", 1)]
    [DataRow("001", 2)]
    [DataRow("110", 2)]
    [DataRow("010", 3)]
    [DataRow("101", 3)]
    [DataRow("00101", 3)]
    [DataRow("0001", 1)]
    [DataRow("00011", 2)]
    [DataRow("11100", 2)]
    [DataRow("0011", 3)]
    [DataRow("1100", 3)]
    [DataRow("0101", 4)]
    [DataRow("1010", 4)]
    [DataRow("000111", 3)]
    [DataRow("111000", 3)]
    [DataRow("001100", 4)]
    [DataRow("110011", 4)]
    [DataRow("0101010101", 10)]
    [DataRow("0000000000", 1)]
    [DataRow("1111111111", 1)]
    [DataRow("001011", 4)]
    [DataRow("110100", 4)]
    [DataRow("000111000111", 6)]
    [DataRow("01111000", 5)]
    [DataRow("0101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101", 100)]
    [DataRow("0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", 1)]
    public void CountValidPrefixes_WithGivenBinaryString_ReturnsValidPrefixesCount(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountValidPrefixes(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}