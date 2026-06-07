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

using LeetCode.Algorithms.LongestHappyString;

namespace LeetCode.Tests.Algorithms.LongestHappyString;

public abstract class LongestHappyStringTestsBase<T> where T : ILongestHappyString, new()
{
    [TestMethod]
    [DataRow(1, 1, 7, "ccbccacc")]
    [DataRow(7, 1, 0, "aabaa")]
    [DataRow(0, 0, 0, "")]
    [DataRow(0, 0, 1, "c")]
    [DataRow(0, 1, 0, "b")]
    [DataRow(1, 0, 0, "a")]
    [DataRow(0, 0, 5, "cc")]
    [DataRow(0, 5, 0, "bb")]
    [DataRow(5, 0, 0, "aa")]
    [DataRow(0, 1, 1, "bc")]
    [DataRow(1, 0, 1, "ac")]
    [DataRow(1, 1, 0, "ab")]
    [DataRow(0, 0, 10, "cc")]
    [DataRow(10, 0, 0, "aa")]
    [DataRow(0, 10, 0, "bb")]
    [DataRow(3, 1, 0, "aaba")]
    [DataRow(3, 2, 0, "aabba")]
    [DataRow(2, 1, 0, "aab")]
    [DataRow(0, 2, 1, "bbc")]
    [DataRow(1, 0, 2, "cca")]
    [DataRow(1, 3, 0, "bbab")]
    [DataRow(0, 1, 3, "ccbc")]
    public void LongestDiverseString_WithCharacterCounts_ReturnsLongestPossibleString(int a, int b, int c, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LongestDiverseString(a, b, c);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}