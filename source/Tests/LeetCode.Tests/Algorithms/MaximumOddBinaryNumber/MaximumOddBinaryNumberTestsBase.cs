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

using LeetCode.Algorithms.MaximumOddBinaryNumber;

namespace LeetCode.Tests.Algorithms.MaximumOddBinaryNumber;

public abstract class MaximumOddBinaryNumberTestsBase<T> where T : IMaximumOddBinaryNumber, new()
{
    [TestMethod]
    [DataRow("010", "001")]
    [DataRow("0101", "1001")]
    [DataRow("1", "1")]
    [DataRow("11", "11")]
    [DataRow("111", "111")]
    [DataRow("0001", "0001")]
    [DataRow("1000", "0001")]
    [DataRow("10", "01")]
    [DataRow("110", "101")]
    [DataRow("0110", "1001")]
    [DataRow("1010", "1001")]
    [DataRow("1100", "1001")]
    [DataRow("01110", "11001")]
    [DataRow("10101", "11001")]
    [DataRow("000111", "110001")]
    [DataRow("1001001", "1100001")]
    [DataRow("00000001", "00000001")]
    [DataRow("11111110", "11111101")]
    [DataRow("0101010", "1100001")]
    [DataRow("0101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101", "1111111111111111111111111111111111111111111111111000000000000000000000000000000000000000000000000001")]
    public void MaximumOddBinaryNumber_GivenBinaryString_ReturnsMaximumOddBinaryNumber(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumOddBinaryNumber(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}