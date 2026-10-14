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

using LeetCode.Algorithms.NumberOfSubstringsWithOnlyOnes;

namespace LeetCode.Tests.Algorithms.NumberOfSubstringsWithOnlyOnes;

public abstract class NumberOfSubstringsWithOnlyOnesTestsBase<T> where T : INumberOfSubstringsWithOnlyOnes, new()
{
    [TestMethod]
    [DataRow("0110111", 9)]
    [DataRow("101", 2)]
    [DataRow("111111", 21)]
    [DataRow("0", 0)]
    [DataRow("1", 1)]
    [DataRow("00", 0)]
    [DataRow("11", 3)]
    [DataRow("10", 1)]
    [DataRow("01", 1)]
    [DataRow("1111", 10)]
    [DataRow("0000", 0)]
    [DataRow("1010101", 4)]
    [DataRow("110011", 6)]
    [DataRow("111111111111111111111111111111", 465)]
    [DataRow("0000000000000000000000000", 0)]
    [DataRow("111111111101111111111", 110)]
    [DataRow("0001110001", 7)]
    [DataRow("111110111110", 30)]
    [DataRow("1110000100101101000110010", 16)]
    [DataRow("0111111100001010000111", 36)]
    [DataRow("10100111000001010011101010", 18)]
    public void NumSub_WithBinaryString_ReturnsCountOfAllOneSubstrings(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumSub(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}