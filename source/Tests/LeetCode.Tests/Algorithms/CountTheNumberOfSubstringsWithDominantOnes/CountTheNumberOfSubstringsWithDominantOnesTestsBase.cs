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

using LeetCode.Algorithms.CountTheNumberOfSubstringsWithDominantOnes;

namespace LeetCode.Tests.Algorithms.CountTheNumberOfSubstringsWithDominantOnes;

public abstract class CountTheNumberOfSubstringsWithDominantOnesTestsBase<T> where T : ICountTheNumberOfSubstringsWithDominantOnes, new()
{
    [TestMethod]
    [DataRow("0", 0)]
    [DataRow("1", 1)]
    [DataRow("00", 0)]
    [DataRow("11", 3)]
    [DataRow("01", 2)]
    [DataRow("10", 2)]
    [DataRow("000", 0)]
    [DataRow("111", 6)]
    [DataRow("00011", 5)]
    [DataRow("101101", 16)]
    [DataRow("0000", 0)]
    [DataRow("1111", 10)]
    [DataRow("0101010101", 18)]
    [DataRow("1111100000", 22)]
    [DataRow("100", 2)]
    [DataRow("110", 5)]
    [DataRow("010", 3)]
    [DataRow("1011011", 23)]
    [DataRow("0110", 7)]
    [DataRow("111000111", 18)]
    [DataRow("11111111111111111111", 210)]
    [DataRow("00000000001111111111", 74)]
    [DataRow("1010101010101010", 30)]
    [DataRow("110100110", 17)]
    [DataRow("0001000", 3)]
    public void NumberOfSubstrings_WithBinaryString_ReturnsDominantOnesSubstringCount(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumberOfSubstrings(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}