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

using LeetCode.Algorithms.MinimumNumberOfChangesToMakeBinaryStringBeautiful;

namespace LeetCode.Tests.Algorithms.MinimumNumberOfChangesToMakeBinaryStringBeautiful;

public abstract class MinimumNumberOfChangesToMakeBinaryStringBeautifulTestsBase<T>
    where T : IMinimumNumberOfChangesToMakeBinaryStringBeautiful, new()
{
    [TestMethod]
    [DataRow("0000", 0)]
    [DataRow("10", 1)]
    [DataRow("1001", 2)]
    [DataRow("00", 0)]
    [DataRow("11", 0)]
    [DataRow("01", 1)]
    [DataRow("0011", 0)]
    [DataRow("0101", 2)]
    [DataRow("0110", 2)]
    [DataRow("1100", 0)]
    [DataRow("1010", 2)]
    [DataRow("000111", 1)]
    [DataRow("010101", 3)]
    [DataRow("101010", 3)]
    [DataRow("001100", 0)]
    [DataRow("011011", 2)]
    [DataRow("1111", 0)]
    [DataRow("00110011", 0)]
    [DataRow("01010101", 4)]
    [DataRow("10101010", 4)]
    [DataRow("0000000011", 0)]
    [DataRow("1001100101", 5)]
    [DataRow("0111001101", 2)]
    public void MinChanges_GivenBinaryString_ReturnsMinimumChangeCount(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinChanges(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}